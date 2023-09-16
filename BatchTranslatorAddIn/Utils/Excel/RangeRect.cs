using Microsoft.Office.Interop.Excel;
using System.Collections;

namespace BatchTranslatorAddIn.Utils.Excel
{
    /**
     * <summary>
     * Excel工具类 <br/>
     * 封装Microsoft.Office.Interop.Excel.Range类 <br/>
     * 实现符合C#语法规范（以及个人认知）的常用方法 <br/>
     * 解决开始下标为1等问题，治疗高血压
     * </summary>
     */
    public class RangeRect : IEnumerable
    {
        public RangeRect(Range range)
        {
            RawRange = range;
        }
        public Range RawRange { get; set; }
        public string Value { get => (string)RawRange.Value2; set => RawRange.Value2 = value; }
        public int Count => RawRange.Count;
        public bool IsSingle => RawRange.Count == 1;
        public bool IsColumn => !IsSingle && RawRange.Columns.Count == 1;
        public bool IsRow => !IsSingle && RawRange.Rows.Count == 1;
        public int Width => RawRange.Columns.Count;
        public int Height => RawRange.Rows.Count;
        public RangeRect this[int x, int y]
        {
            get => new RangeRect(RawRange.Cells[y + 1, x + 1] as Range);
            set => (RawRange.Cells[y + 1, x + 1] as Range).Value2 = value.Value;
        }
        public RangeRect Offset(int x, int y) => new RangeRect(RawRange.Offset[y, x]);
        public void InsertColumnToRight()
        {
            this[Width - 1, 0].Offset(1, 0).RawRange.EntireColumn.Insert(XlInsertShiftDirection.xlShiftToRight);
        }
        public void InsertRowToBottom()
        {
            this[0, Height - 1].Offset(0, 1).RawRange.EntireRow.Insert(XlInsertShiftDirection.xlShiftDown);
        }
        public RangeRect Row(int yIndex)
        {
            return new RangeRect(RawRange.Rows.Item[yIndex + 1] as Range);
        }
        public RangeRect Column(int xIndex)
        {
            return new RangeRect(RawRange.Columns.Item[xIndex + 1] as Range);
        }
        public RangeRect[] Rows
        {
            get
            {
                var rowsArr = new RangeRect[this.Height];
                for (int i = 0; i < this.Height; i++)
                    rowsArr[i] = Row(i);
                return rowsArr;
            }
        }
        public RangeRect[] Columns
        {
            get
            {
                var columnArr = new RangeRect[this.Width];
                for (int i = 0; i < this.Width; i++)
                    columnArr[i] = Column(i);
                return columnArr;
            }
        }
        // 从左到右，从上到下遍历
        public IEnumerator GetEnumerator()
        {
            return new SelectedRectEnumerator(this);
        }

        class SelectedRectEnumerator : IEnumerator
        {
            public object Current => _selectedRect[_xIndex, _yIndex];

            public bool MoveNext()
            {
                if (_xIndex >= _selectedRect.Width - 1 && _yIndex >= _selectedRect.Height - 1)
                    return false;
                if (_xIndex >= _selectedRect.Width - 1)
                    (_xIndex, _yIndex) = (0, _yIndex + 1);
                else
                    _xIndex++;
                return true;
            }

            public void Reset()
            {
                _xIndex = 0;
                _yIndex = 0;
            }

            readonly RangeRect _selectedRect;
            int _xIndex;
            int _yIndex;
            public SelectedRectEnumerator(RangeRect selectedRect)
            {
                _selectedRect = selectedRect;
                _xIndex = 0;
                _yIndex = 0;
            }
        }
    }
}

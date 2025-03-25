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
            _rawRange = range;
        }
        private Range _rawRange;
        public string Value { get => (string)_rawRange.Value2; set => _rawRange.Value2 = value; }
        public int Count => _rawRange.Count;
        public bool IsCell => _rawRange.Count == 1;
        public bool IsColumn => !IsCell && _rawRange.Columns.Count == 1;
        public bool IsRow => !IsCell && _rawRange.Rows.Count == 1;
        public int Width => _rawRange.Columns.Count;
        public int Height => _rawRange.Rows.Count;
        public string Address => _rawRange.Address.Replace("$", "");
        public RangeRect this[int x, int y]
        {
            get => new RangeRect(_rawRange.Cells[y + 1, x + 1] as Range);
            set => (_rawRange.Cells[y + 1, x + 1] as Range).Value2 = value.Value;
        }
        public RangeRect Offset(int x, int y) => new RangeRect(_rawRange.Offset[y, x]);
        public void InsertColumnToRight()
        {
            this[Width - 1, 0].Offset(1, 0)._rawRange.EntireColumn.Insert(XlInsertShiftDirection.xlShiftToRight);
        }
        public void InsertRowToBottom()
        {
            this[0, Height - 1].Offset(0, 1)._rawRange.EntireRow.Insert(XlInsertShiftDirection.xlShiftDown);
        }
        public RangeRect Row(int yIndex)
        {
            return new RangeRect(_rawRange.Rows.Item[yIndex + 1] as Range);
        }
        public RangeRect Column(int xIndex)
        {
            return new RangeRect(_rawRange.Columns.Item[xIndex + 1] as Range);
        }
        public RangeRect[] Rows
        {
            get
            {
                var rowsArr = new RangeRect[Height];
                for (int i = 0; i < Height; i++)
                    rowsArr[i] = Row(i);
                return rowsArr;
            }
        }
        public RangeRect[] Columns
        {
            get
            {
                var columnArr = new RangeRect[Width];
                for (int i = 0; i < Width; i++)
                    columnArr[i] = Column(i);
                return columnArr;
            }
        }

        /// <summary>
        /// 从左到右，从上到下遍历
        /// </summary>
        /// <returns></returns>
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

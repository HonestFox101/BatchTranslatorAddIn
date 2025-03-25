namespace BatchTranslatorAddIn.Utils.Excel
{
    public abstract class Operations
    {
        /**
         * <summary>当前选中的Excel格，结果可能为null</summary>
         */
        public static RangeRect GetSelectedRect()
        {
            var selectedRange = Globals.ThisAddIn.Application.ActiveWindow.RangeSelection;
            return selectedRange != null ? new RangeRect(selectedRange) : null;
        }
    }
}

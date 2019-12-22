using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.XtraGrid.Views.Grid;

namespace IsSoft.Sec.LedChecker
{
    public class GridBookmark
    {
        public GridBookmark(GridView view)
        {
            this.view = view;
            rowHandle = -1;
        }

        private GridView view;

        private int rowHandle;

        public void Get(int rowHandle = -1)
        {
            if (view.RowCount == 0)
            {
                this.rowHandle = -1;
                return;
            }

            if (rowHandle < 0)
                this.rowHandle = view.GetDataSourceRowIndex(view.FocusedRowHandle);
            else
                this.rowHandle = rowHandle;
        }

        public void Goto(int rowHandle = -1)
        {
            rowHandle = (rowHandle < 0) ? this.rowHandle : rowHandle;

            if (rowHandle < 0) return;
            if (view.RowCount == 0) return;

            for (int i = 0; i < view.DataRowCount; i++)
            {
                if (view.GetDataSourceRowIndex(i) == rowHandle)
                {
                    view.FocusedRowHandle = i;
                }
            }
        }
    }
}

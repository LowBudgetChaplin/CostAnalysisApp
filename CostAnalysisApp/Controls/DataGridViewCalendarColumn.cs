using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostAnalysis.WinForms.Controls
{
    public class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        DataGridView _grid;
        bool _valueChanged;
        int _rowIndex;

        public object EditingControlFormattedValue
        {
            get => Value.ToString("yyyy-MM-dd");
            set
            {
                if (value is string s && DateTime.TryParse(s, out var dt))
                    Value = dt;
            }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
            => EditingControlFormattedValue;

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            Font = dataGridViewCellStyle.Font;
            CalendarForeColor = dataGridViewCellStyle.ForeColor;
            CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        public int EditingControlRowIndex { get => _rowIndex; set => _rowIndex = value; }
        public bool EditingControlValueChanged { get => _valueChanged; set => _valueChanged = value; }
        public Cursor EditingPanelCursor => Cursor;
        public bool RepositionEditingControlOnValueChange => false;

        public void PrepareEditingControlForEdit(bool selectAll) { }

        public DataGridView EditingControlDataGridView
        {
            get => _grid;
            set => _grid = value;
        }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            _valueChanged = true;
            _grid.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }

        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
            => true;
    }

    public class DataGridViewCalendarCell : DataGridViewTextBoxCell
    {
        public DataGridViewCalendarCell()
        {
            Style.Format = "yyyy-MM-dd";
        }

        public override Type EditType => typeof(CalendarEditingControl);
        public override Type ValueType => typeof(DateTime);
        public override object DefaultNewRowValue => DateTime.Today;

        public override void InitializeEditingControl(
            int rowIndex, object initialFormattedValue,
            DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            var ctl = DataGridView.EditingControl as CalendarEditingControl;
            if (initialFormattedValue is DateTime dt)
                ctl.Value = dt;
        }
    }

    public class DataGridViewCalendarColumn : DataGridViewColumn
    {
        public DataGridViewCalendarColumn()
            : base(new DataGridViewCalendarCell())
        {
        }

        public override DataGridViewCell CellTemplate
            => base.CellTemplate;
    }
}

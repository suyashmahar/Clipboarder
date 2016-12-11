using System;
using System.Windows.Forms;

namespace Clipboarder {

    public class HybridCellColumn : DataGridViewColumn {
        public HybridCellColumn() : base(new HybridCell()) {

        }

        public override DataGridViewCell CellTemplate {
            get {
                return base.CellTemplate;
            }

            set {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(HybridCell))){
                    throw new InvalidCastException("Must be a Hybrid Cell");
                }
                base.CellTemplate = value;
            }
        }
    }

    class HybridCell : DataGridViewCell {
        public HybridCell() : base() {
            
        }
    }
}

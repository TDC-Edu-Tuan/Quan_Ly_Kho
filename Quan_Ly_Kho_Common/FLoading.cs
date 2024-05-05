using DevExpress.XtraWaitForm;

namespace Quan_Ly_Kho_Common
{
    public partial class FLoading : WaitForm
    {
        public FLoading()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;

            // Thiết lập StartPosition cho form giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }
    }
}
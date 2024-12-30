namespace WinFormsApp1
{
    partial class PoliceEdit
    {
        private System.ComponentModel.IContainer components = null;
        private string currentBidId; // ID текущей заявки, которую нужно изменить

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public PoliceEdit(string reason, string bidId)
        {
            InitializeComponent();
            textBoxReason.Text = reason; // Установка текста причины
            currentBidId = bidId; // Сохранение ID заявки
        }

        private void InitializeComponent()
        {
            // Инициализация элементов управления
            textBoxReason = new TextBox();
            radioButtonApprove = new RadioButton();
            radioButtonDecline = new RadioButton();
            buttonOk = new Button();
            buttonCancel = new Button();

            SuspendLayout();
            // 
            // textBoxReason
            // 
            textBoxReason.Location = new Point(10, 10); // Установка отступов от краев
            textBoxReason.Multiline = true;
            textBoxReason.Name = "textBoxReason";
            textBoxReason.ReadOnly = true;
            textBoxReason.ScrollBars = ScrollBars.Vertical;
            textBoxReason.Size = new Size(380, 200); // Установка размера текстового поля
            textBoxReason.TabIndex = 0;

            // 
            // radioButtonApprove
            // 
            radioButtonApprove.Location = new Point(10, 220);
            radioButtonApprove.Name = "radioButtonApprove";
            radioButtonApprove.Size = new Size(100, 20);
            radioButtonApprove.TabIndex = 1;
            radioButtonApprove.Text = "Одобрить";

            // 
            // radioButtonDecline
            // 
            radioButtonDecline.Location = new Point(120, 220);
            radioButtonDecline.Name = "radioButtonDecline";
            radioButtonDecline.Size = new Size(100, 20);
            radioButtonDecline.TabIndex = 2;
            radioButtonDecline.Text = "Отклонить";

            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(220, 250);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 30);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "ОК";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += new EventHandler(this.ButtonOk_Click); // Подписка на событие клика

            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(300, 250);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 30);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += new EventHandler(this.ButtonCancel_Click); // Подписка на событие клика

            // 
            // PoliceEdit
            // 
            ClientSize = new Size(400, 300);
            Controls.Add(textBoxReason);
            Controls.Add(radioButtonApprove);
            Controls.Add(radioButtonDecline);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancel);
            Name = "PoliceEdit";
            Text = "Reason Details";
            ResumeLayout(false);
            PerformLayout();
        }

        

        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.RadioButton radioButtonApprove;
        private System.Windows.Forms.RadioButton radioButtonDecline;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddConditionForm : Form
    {
        public Condition NewCondition { get; private set; }
        private int currentId;

        private TextBox textBoxReason;
        private TextBox textBoxAllowedTime;
        private TextBox textBoxDate;
        private TextBox textBoxStatus;
        private Button buttonSubmit;
        private Button buttonCancel;

        public AddConditionForm(int nextId)
        {
            InitializeComponent();
            currentId = nextId; 
            InitializeFields();
        }

        private void InitializeFields()
        {
            Label labelReason = new Label { Text = "Причина:", Location = new System.Drawing.Point(12, 12) };
            Label labelAllowedTime = new Label { Text = "Дней:", Location = new System.Drawing.Point(12, 40) };
            Label labelDate = new Label { Text = "Дата:", Location = new System.Drawing.Point(12, 68) };
            Label labelStatus = new Label { Text = "Статус:", Location = new System.Drawing.Point(12, 96) };

            textBoxReason = new TextBox { Location = new System.Drawing.Point(150, 12), Width = 200 };
            textBoxAllowedTime = new TextBox { Location = new System.Drawing.Point(150, 40), Width = 200 };
            textBoxDate = new TextBox { Location = new System.Drawing.Point(150, 68), Width = 200 };
            textBoxStatus = new TextBox { Location = new System.Drawing.Point(150, 96), Width = 200, Text = "y" }; // Устанавливаем статус по умолчанию

            buttonSubmit = new Button
            {
                Text = "Добавить",
                Location = new System.Drawing.Point(12, 124),
                Size = new System.Drawing.Size(100, 30)
            };
            buttonSubmit.Click += ButtonSubmit_Click;

            buttonCancel = new Button
            {
                Text = "Отмена",
                Location = new System.Drawing.Point(150, 124),
                Size = new System.Drawing.Size(100, 30)
            };
            buttonCancel.Click += ButtonCancel_Click;

            Controls.Add(labelReason);
            Controls.Add(labelAllowedTime);
            Controls.Add(labelDate);
            Controls.Add(labelStatus);
            Controls.Add(textBoxReason);
            Controls.Add(textBoxAllowedTime);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxStatus);
            Controls.Add(buttonSubmit);
            Controls.Add(buttonCancel);
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            NewCondition = new Condition(
                currentId, 
                textBoxReason.Text,
                textBoxAllowedTime.Text,
                textBoxDate.Text,
                textBoxStatus.Text 
            );

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
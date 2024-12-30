using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminForm : Form
    {
        private DataGridView dataGridViewConditions;
        private ConditionController conditionController;
        private Button buttonAddCondition;
        private Button buttonCancel;

        public AdminForm()
        {
            InitializeComponent();
            conditionController = new ConditionController();
            InitializeDataGridView();
            InitializeAddConditionButton();
            LoadConditionsFromCsv("Condition.csv");
            PopulateDataGridView();

            dataGridViewConditions.CellClick += DataGridViewConditions_CellClick;
        }

        private void InitializeDataGridView()
        {
            dataGridViewConditions = new DataGridView
            {
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                Location = new System.Drawing.Point(12, 12),
                Size = new System.Drawing.Size(600, 300)
            };
            Controls.Add(dataGridViewConditions);
        }

        private void InitializeAddConditionButton()
        {
            buttonAddCondition = new Button
            {
                Text = "Добавить условие",
                Location = new System.Drawing.Point(12, 320),
                Size = new System.Drawing.Size(120, 30)
            };
            buttonAddCondition.Click += ButtonAddCondition_Click;
            Controls.Add(buttonAddCondition);

            buttonCancel = new Button
            {
                Text = "Отмена",
                Location = new System.Drawing.Point(500, 320),
                Size = new System.Drawing.Size(100, 30)
            };
            buttonCancel.Click += ButtonCancel_Click;
            Controls.Add(buttonCancel);
        }

        private void ButtonAddCondition_Click(object sender, EventArgs e)
        {
            int nextId = conditionController.GetNextConditionId();
            using (var form = new AddConditionForm(nextId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var newCondition = form.NewCondition;
                    conditionController.CreateCondition(newCondition);
                    PopulateDataGridView(); 
                }
            }
        }

        private void LoadConditionsFromCsv(string filePath)
        {
            conditionController.GetConditionsFromService(filePath);
        }

        private void PopulateDataGridView()
        {
            dataGridViewConditions.DataSource = conditionController.GetAllConditions();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            Close();
        }

        private void DataGridViewConditions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                var selectedCondition = (Condition)dataGridViewConditions.Rows[e.RowIndex].DataBoundItem; 

                  selectedCondition.Status = "n";
                conditionController.EditCondition(selectedCondition); 

                var addConditionForm = new AddConditionForm(conditionController.GetNextConditionId());
                if (addConditionForm.ShowDialog() == DialogResult.OK)
                {
                    var newCondition = addConditionForm.NewCondition; 
                    conditionController.CreateCondition(newCondition); 
                }

                PopulateDataGridView(); 
            }
        }
    }
}
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class PoliceEdit : Form
    {

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            string newStatus;
            if (radioButtonApprove.Checked)
            {
                newStatus = "Given"; 
            }
            else if (radioButtonDecline.Checked)
            {
                newStatus = "Rejected"; 
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите действие (Одобрить или Отклонить).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            UpdateBidStatus(currentBidId, newStatus);

            this.Close(); 
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void UpdateBidStatus(string bidId, string newStatus)
        {
            var bidController = new BidController();
            BidStatus statusEnum;

            if (Enum.TryParse(newStatus, out statusEnum))
            {
                bidController.UpdateBidStatus(bidId, statusEnum);
            }
            else
            {
                MessageBox.Show("Не удалось преобразовать статус заявки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
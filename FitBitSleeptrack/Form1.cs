using System.Globalization;

namespace FitBitSleeptrack
{
    public partial class FitBitSleepTracker : Form
    {
        public FitBitSleepTracker()
        {
            InitializeComponent();

            tbFileName.Text = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss", CultureInfo.CurrentCulture);
            controller.fileName = tbFileName.Text;
            controller.statusLabel = toolStripStatusLabel1;
            controller.logbox = rtbLog;

        }

        Controller controller = new Controller();

        private void cbTimeSpan_CheckedChanged(object sender, EventArgs e)
        {
            grpTimeSpan.Visible = cbTimeSpan.Checked;
            foreach(Control controlToShowOrHide in grpTimeSpan.Controls)
            {
                controlToShowOrHide.Visible = cbTimeSpan.Checked;

            }

            if(cbBeforeAfter.SelectedIndex == -1)
            {
                cbBeforeAfter.SelectedIndex = 0;

            }
        }

        private void FitBitSleepTracker_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            DataSource dataSource;
            if (cbTimeSpan.Checked)
            {
                dataSource = DataSource.multiDay;

            }
            else
            {
                dataSource = DataSource.singleDay;

            }

            tbFileName.Text = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss", CultureInfo.CurrentCulture);
            controller.fileName = tbFileName.Text;

            

            controller.ExecuteRequest(dataSource, tbTargetDay.Text, cbBeforeAfter.SelectedIndex, (int)daysToRetrieve.Value);

        }
    }
}
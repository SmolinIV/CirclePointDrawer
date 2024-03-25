using System.Text;
using CirclePointFinder.Presenter;
using CirclePointFinder.Views;

namespace CirclePointFinder
{
    public partial class PointsView : Form, IPointsInCircle
    {
        public PointsView()
        {
            InitializeComponent();
        }

        public string FirstPointPositionX
        {
            get => txtPoint1X.Text;
            set => txtPoint1X.Text = value;
        }
        public string FirstPointPositionY
        {
            get => txtPoint1Y.Text;
            set => txtPoint1Y.Text = value;
        }
        public string SecondPointPositionX
        {
            get => txtPoint2X.Text;
            set => txtPoint2X.Text = value;
        }
        public string SecondPointPositionY
        {
            get => txtPoint2Y.Text;
            set => txtPoint2Y.Text = value;
        }
        public string Radius
        {
            get => txtRadius.Text;
            set => txtRadius.Text = value;
        }
        public string PointsCount
        {
            get => txtPointsCount.Text;
            set => txtPointsCount.Text = value;
        }
        public bool IsSearchingCounterClockwise { get; set; } = false;

        public event Action<bool> SearchRequired;

        public void ShowPoints(List<KeyValuePair<double, double>> points)
        {
            ImportPointsToTable(points);
        }

        public void ShowMessegeBox(string message) =>
            MessageBox.Show(message);

        private void PointsView_Load(object sender, EventArgs e)
        {
            rbtClockwise.Checked = true;
            lblResultHeader.Visible = false;

            PointsOnCirclePresenter presenter = new PointsOnCirclePresenter(this);
        }

        private void rbtCounterClockwise_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCounterClockwise.Checked)
                IsSearchingCounterClockwise = false;
        }

        private void rbtClockwise_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtClockwise.Checked)
                IsSearchingCounterClockwise = true;
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (CheckFieldIsFilling())
                SearchRequired?.Invoke(IsSearchingCounterClockwise);
        }

        private bool CheckFieldIsFilling()
        {
            string textMessege = string.Empty;

            if (string.IsNullOrEmpty(txtPoint1X.Text) || string.IsNullOrEmpty(txtPoint1Y.Text))
                textMessege = $"Fields of \"{lblPoint1.Text}\" cannot be empty";
            else if (string.IsNullOrEmpty(txtPoint2X.Text) || string.IsNullOrEmpty(txtPoint2Y.Text))
                textMessege = $"Fields of \"{lblPoint2.Text}\" cannot be empty";
            else if (string.IsNullOrEmpty(txtRadius.Text))
                textMessege = $"Field \"{lblRadius}\" cannot be empty";
            else if (string.IsNullOrEmpty(txtPointsCount.Text))
                textMessege = $"Field \"{lblPointsCount.Text}\" cannot be empty";

            if (string.IsNullOrEmpty(textMessege))
                return true;

            ShowMessegeBox(textMessege);
            return false;
        }

        private void ImportPointsToTable(List<KeyValuePair<double, double>> points)
        {
            int indexCorrection = 1;
            int roundNumber = 2;

            listView1.Items.Clear();

            ListViewItem item;

            for (int i = 0; i < points.Count; i++)
            {
                item = new ListViewItem(new string[]
                    {
                       $"Point {i + indexCorrection}",
                       $"{Math.Round(points[i].Key, roundNumber)} ; {Math.Round(points[i].Value, roundNumber)}"
                    }
                );

                listView1.Items.Add( item );
            }
        }
    }
}

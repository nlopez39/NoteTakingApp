using System.Data;

namespace NoteTakingAppCorrect
{
    public partial class Form1 : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //build columns for the datagridView
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");
            //output these new values to the datagridview
            DataGridView.DataSource = notes;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(editing)
            {
                //if editing is true then overwrite the old one
                notes.Rows[DataGridView.CurrentCell.RowIndex]["Title"] = TitleBox.Text;
                notes.Rows[DataGridView.CurrentCell.RowIndex]["Note"]= NoteBox.Text;
            }
            else
            {
             //save a note by placing text in the row 
            notes.Rows.Add(TitleBox.Text, NoteBox.Text);
            }
            TitleBox.Text = "";
            NoteBox.Text = "";
            editing = false; 

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            //edit an already existing note
            //load a note/row to the textbox, when someone clicks on the current cell
            TitleBox.Text = notes.Rows[DataGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
            NoteBox.Text = notes.Rows[DataGridView.CurrentCell.RowIndex].ItemArray[1].ToString();

            editing = true;

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                //we will try to delete a row
                notes.Rows[DataGridView.CurrentCell.RowIndex].Delete(); 

            }
            catch {
                Console.WriteLine("That is not a row");
              }
        }

        private void New_Click(object sender, EventArgs e)
        {
            //clear out the text Boxes
            TitleBox.Text = "";
            NoteBox.Text = "";
        }
        //if user clicked on cell
        private void DataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TitleBox.Text = notes.Rows[DataGridView.CurrentCell.RowIndex]["Title"].ToString();
            NoteBox.Text = notes.Rows[DataGridView.CurrentCell.RowIndex]["Note"].ToString();

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TitleBox.Text = notes.Rows[DataGridView.CurrentCell.RowIndex]["Title"].ToString();
            NoteBox.Text = notes.Rows[DataGridView.CurrentCell.RowIndex]["Note"].ToString();

        }
    }
}    
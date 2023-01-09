using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC
{
    public partial class usState : UserControl
    {
        public usState()
        {
            InitializeComponent();
        }

        public States SelectedState
        {
            get
            {
                return (States)cboState.SelectedItem;
            }
        }




   
        private void usState_Load(object sender, EventArgs e)
        {
            List<States> states = new List<States>();
            states.Add(new States { ID = 1, Name = "Alabama" });
            states.Add(new States { ID = 2, Name = "Alaska" });
            states.Add(new States { ID = 3, Name = "Arizona" });
            states.Add(new States { ID = 4, Name = "Arkansas" });
            states.Add(new States { ID = 5, Name = "California" });
            states.Add(new States { ID = 6, Name = "Colorado" });
            states.Add(new States { ID = 7, Name = "Connecticut" });
            states.Add(new States { ID = 8, Name = "Delaware" });
            states.Add(new States { ID = 9, Name = "Florida" });
            states.Add(new States { ID = 10, Name = "Georgia" });
            states.Add(new States { ID = 11, Name = "Hawaii" });
            states.Add(new States { ID = 12, Name = "Idaho" });
            states.Add(new States { ID = 13, Name = "Illinois" });
            states.Add(new States { ID = 14, Name = "Indiana" });
            states.Add(new States { ID = 15, Name = "Iowa" });
            states.Add(new States { ID = 16, Name = "Kansas" });
            states.Add(new States { ID = 17, Name = "Kentucky" });
            states.Add(new States { ID = 18, Name = "Louisiana" });
            states.Add(new States { ID = 19, Name = "Maine" });
            states.Add(new States { ID = 20, Name = "Maryland" });
            states.Add(new States { ID = 21, Name = "Massachusetts" });
            states.Add(new States { ID = 22, Name = "Michigan" });
            states.Add(new States { ID = 23, Name = "Minnesota" });
            states.Add(new States { ID = 24, Name = "Mississippi" });
            states.Add(new States { ID = 25, Name = "Missouri" });
            states.Add(new States { ID = 26, Name = "Montana" });
            states.Add(new States { ID = 27, Name = "Nebraska" });
            states.Add(new States { ID = 28, Name = "Nevada" });


            
           
            cboState.DataSource = states;
            cboState.DisplayMember = "Name";
            cboState.ValueMember = "ID";


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Napier_Couriers
{
    public partial class FormNapierCouriers : Form
    {
        PickUp pickup1 = new PickUp();
        Delivery delivery1 = new Delivery();
        Van van1 = new Van();
        // LISTS:
        List<object> pickuplist = new List<object>();
        List<object> deliverylist = new List<object>();
        List<string> vanlist = new List<string>();
        List<object> summarylist = new List<object>();
        List<object> holdlist = new List<object>();
        List<object> holdlist1 = new List<object>();
        List<object> holdlist2 = new List<object>();
        List<object> holdlist3 = new List<object>();
        public FormNapierCouriers()
        {
            InitializeComponent();
            // LOAD DATA on start-up:
            string line;
            var file = new System.IO.StreamReader("C:\\Users\\New User\\Desktop\\SystemData");
            while ((line = file.ReadLine()) != null)
            {
                listBoxSummary.Items.Add(line);
            }
            // LOAD DATA on start-up:
            string line2;
            var file2 = new System.IO.StreamReader("C:\\Users\\New User\\Desktop\\PICKUP");
            while ((line2 = file2.ReadLine()) != null)
            {
                listBoxPickUp.Items.Add(line2);
            }
            // LOAD DATA on start-up:
            string line3;
            var file3 = new System.IO.StreamReader("C:\\Users\\New User\\Desktop\\DELIVERY");
            while ((line3 = file3.ReadLine()) != null)
            {
                listBoxShowDelivery.Items.Add(line3);
            }
            // VANS: Add new vans:
            vanlist.Add("001");
            vanlist.Add("002");
            vanlist.Add("003");
            vanlist.Add("004");
            // Initialise the data source to selected list boxes:
            listBoxVanVisits.DataSource = vanlist;
            listBoxSelectVan.DataSource = vanlist;
            listBoxPUAllocate.DataSource = vanlist;
            listBoxDAllocate.DataSource = vanlist;
        }
        // FORM LOAD:
        private void FormNapierCouriers_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
        // ADD NEW PICK UP:
        private void btnAddNewPickUp_Click(object sender, EventArgs e)
        {
            // If a text box is empty....
            if (String.IsNullOrEmpty(RTxtBoxPUForename.Text)
                   || (String.IsNullOrEmpty(RTxtBoxPUSurname.Text))
                     || (String.IsNullOrEmpty(RTxtBoxPUAddress.Text))
                || (String.IsNullOrEmpty(RTxtBoxPUATime.Text)))
                MessageBox.Show("Please check that you have filled in all text boxes.", "Message:", MessageBoxButtons.OK, MessageBoxIcon.Information); //error message.
            else
            {
                string PUName = RTxtBoxPUDName.Text;
                string PUDAddress = RTxtBoxPUDAddress.Text;
                string PUForename = RTxtBoxPUForename.Text;
                string PUSurname = RTxtBoxPUSurname.Text;
                string PUAddress = RTxtBoxPUAddress.Text;
                int PUATime = int.Parse(RTxtBoxPUATime.Text);
                string PUVan = RTxtBoxDVanAllocated.Text;
                pickup1.PickUpName = RTxtBoxPUDName.Text;
                pickup1.PickUpAddress = RTxtBoxPUDAddress.Text;
                pickup1.CustomerForename = RTxtBoxPUForename.Text;
                pickup1.CustomerSurname = RTxtBoxPUSurname.Text;
                pickup1.CustomerAddress = RTxtBoxPUAddress.Text;
                pickup1.ArrivalTime = int.Parse(RTxtBoxPUATime.Text);
                van1.VanNumber = RTxtBoxDVanAllocated.Text;
                // Add to the pickuplist/vanlist:
                pickuplist.Add(pickup1.PickUpName);
                pickuplist.Add(pickup1.PickUpAddress);
                pickuplist.Add(pickup1.CustomerForename);
                pickuplist.Add(pickup1.CustomerSurname);
                pickuplist.Add(pickup1.CustomerAddress);
                pickuplist.Add(pickup1.ArrivalTime);
                vanlist.Add(van1.VanNumber);
                lblPUSummary.Visible = true;
                lblPUSummary.Text = "Summary:" + " " + PUName.ToString() + " " + PUForename.ToString() + " " + PUSurname.ToString() + " " + PUAddress.ToString();
                // CHECK BOXES (PICK UP):
                if (checkBox1.Checked)
                {
                    RTxtBoxPUDName.Text = PUForename + " " + PUSurname;
                }
                else
                {
                }
                if (checkBox2.Checked)
                {
                    RTxtBoxPUDAddress.Text = PUAddress;
                }
                else
                {
                }
                // LISTBOXPUALLOCATE SELECTED ITEM: If item is selected from the list box then output the value in the text box.
                if (listBoxPUAllocate.SelectedIndex == -1)
                    MessageBox.Show("Please select an Item first!");
                int selectedIndex = listBoxPUAllocate.SelectedIndex;
                Object selectedItem = listBoxPUAllocate.SelectedItem;
                RTxtBoxPUVanAllocated.Text = selectedItem.ToString(); // Allocate selected list box item to the 'Van Allocated' text box.
                // VALDATION: Character sting length
                // RTxtBoxPUName - let the max length equal to 18.
                RTxtBoxPUDName.MaxLength = 18;
                if (RTxtBoxPUDName.Text.Length >= 19) // if value over 18;
                {
                    MessageBox.Show("Invalid input: The value must be less than or equal to 18 characters"); // Display error message.
                    RTxtBoxPUDName.Clear();
                }
                else
                {
                    //It's acceptable input length.
                }
                // RTxtBoxPUForeName - let the max length equal to 18.
                RTxtBoxPUForename.MaxLength = 18;
                if (RTxtBoxPUForename.Text.Length >= 19) // if value over 18;
                {
                    MessageBox.Show("Invalid input: The value must be less than or equal to 18 characters"); // Display error message.
                    RTxtBoxPUForename.Clear();
                }
                else
                {
                    //It's acceptable input length.
                }
                // RTxtBoxPUSurname - let the max length equal to 18.
                RTxtBoxPUSurname.MaxLength = 18;
                if (RTxtBoxPUSurname.Text.Length >= 19) // if value over 18;
                {
                    MessageBox.Show("Invalid input: The value must be less than or equal to 18 characters"); // Display error message.
                    RTxtBoxPUSurname.Clear();
                }
                else
                {
                    //It's acceptable input length.

                }
                // RTxtBoxPUAddress - let the max length equal to 18.
                RTxtBoxPUDAddress.MaxLength = 18;
                if (RTxtBoxPUDAddress.Text.Length >= 19) // if value over 18;
                {
                    MessageBox.Show("Invalid input: The value must be less than or equal to 18 characters"); // Display error messgae.
                    RTxtBoxPUDAddress.Clear();
                }
                else
                {
                    //It's acceptable input length.
                }
                // RTxtBoxPUATime - let the max length equal to 18.
                RTxtBoxPUATime.MaxLength = 18;
                if (RTxtBoxPUATime.Text.Length >= 19) // if value over 18;
                {
                    MessageBox.Show("Invalid input: The value must be less than or equal to 18 characters"); // Display error message.
                    RTxtBoxPUATime.Clear();
                }
                else
                {
                    //It's acceptable input length.
                }
            }
        }
        private void btnAddDelivery_Click(object sender, EventArgs e)
        {
            {
                // If a text box is empty....
                if (String.IsNullOrEmpty(RTxtBoxDForename.Text)
                       || (String.IsNullOrEmpty(RTxtBoxDSurname.Text))
                         || (String.IsNullOrEmpty(RTxtBoxDAddress.Text))
                           || (String.IsNullOrEmpty(RTxtBoxDATime.Text)))
                    MessageBox.Show("Please check that you have filled in all text boxes.", "Message:", MessageBoxButtons.OK, MessageBoxIcon.Information); //error message.
                else
                {
                    string DForename = RTxtBoxDForename.Text;
                    string DSurname = RTxtBoxDSurname.Text;
                    string DAddress = RTxtBoxDAddress.Text;
                    string DeName = RTxtBoxDeName.Text;
                    string DeAddress = RTxtBoxDeAddress.Text;
                    string DATime = RTxtBoxDATime.Text;
                    string PUVan = RTxtBoxDVanAllocated.Text;
                    delivery1.CustomerForename = RTxtBoxDForename.Text;
                    delivery1.CustomerSurname = RTxtBoxDSurname.Text;
                    delivery1.CustomerAddress = RTxtBoxDAddress.Text;
                    delivery1.DeliveryName = RTxtBoxDeName.Text;
                    delivery1.DeliveryAddress = RTxtBoxDeAddress.Text;
                    delivery1.ArrivalTime = int.Parse(RTxtBoxDATime.Text);
                    van1.VanNumber = RTxtBoxDVanAllocated.Text;
                    // Add to the delivery/van list:
                    deliverylist.Add(delivery1.DeliveryName);
                    deliverylist.Add(delivery1.DeliveryAddress);
                    deliverylist.Add(delivery1.CustomerForename);
                    deliverylist.Add(delivery1.CustomerSurname);
                    deliverylist.Add(delivery1.CustomerAddress);
                    deliverylist.Add(delivery1.ArrivalTime);
                    vanlist.Add(van1.VanNumber);
                    // CHECK BOXES:
                    if (checkBox3.Checked)
                    {
                        RTxtBoxDeName.Text = DForename + " " + DSurname;
                    }
                    else
                    {
                    }

                    if (checkBox4.Checked)
                    {
                        RTxtBoxDeAddress.Text = DAddress;
                    }
                    else
                    {
                    }
                    // LISTBOXPUALLOCATE SELECTED ITEM: If item is selected from the list box then output the value in the text box.
                    if (listBoxDAllocate.SelectedIndex == -1)
                        MessageBox.Show("Please select an Item first!");
                    int selectedIndex = listBoxDAllocate.SelectedIndex;
                    Object selectedItem = listBoxDAllocate.SelectedItem;
                    RTxtBoxDVanAllocated.Text = selectedItem.ToString(); // Allocate list box item text to 'Van allocated' text box.
                    lblDSummary.Visible = true;
                    lblDSummary.Text = "Summary:" + " " + DeName.ToString() + " " + DForename.ToString() + " " + DSurname.ToString() + " " + DAddress.ToString();
                    // VALDATION: Character sting length
                    // RTxtBoxDName - let the max length equal to 18.
                    RTxtBoxDeName.MaxLength = 18;
                    if (RTxtBoxDeName.Text.Length >= 19) // if value over 18;
                    {
                        MessageBox.Show("Invalid input: The value must be less than or equal to 18 characters"); // Display error message.
                        RTxtBoxDeName.Clear();
                    }
                    else
                    {
                        //It's acceptable input length.
                    }
                    // RTxtBoxDForename - let the max length equal to 18.
                    RTxtBoxDForename.MaxLength = 18;
                    if (RTxtBoxDForename.Text.Length >= 19) // if value over 18;
                    {
                        MessageBox.Show("Invalid input: The value must be less than or equal to 18 characters"); // Display error message.
                        RTxtBoxPUForename.Clear();
                    }
                    else
                    {
                        //It's acceptable input length.
                    }
                    // RTxtBoxDSurname - let the max length equal to 18.
                    RTxtBoxDSurname.MaxLength = 18;
                    if (RTxtBoxDSurname.Text.Length >= 19) // if value over 18;
                    {
                        MessageBox.Show("Invalid input: The value must be less than or equal to 18 characters"); // Display error message.
                        RTxtBoxPUSurname.Clear();
                    }
                    else
                    {
                        //It's acceptable input length.
                    }
                    // RTxtBoxDAddress - let the max length equal to 18.
                    RTxtBoxDAddress.MaxLength = 18;
                    if (RTxtBoxDAddress.Text.Length >= 19) // if value over 18;
                    {
                        MessageBox.Show("Invalid input: The value must be less than or equal to 18 characters"); // Display error message.
                        RTxtBoxDAddress.Clear();
                    }
                    else
                    {
                        //It's acceptable input length.
                    }
                    // RTxtBoxDATime - let the max length equal to 18.
                    RTxtBoxDATime.MaxLength = 18;
                    if (RTxtBoxDATime.Text.Length >= 19) // if value over 18;
                    {
                        MessageBox.Show("Invalid input: The value must be less than or equal to 18 characters"); // Display error message.
                    }
                    else
                    {
                        //It's acceptable input length.
                    }
                }
            }
        }
        //QUIT BUTTON: Press this, to exit the application.
        private void lblQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK) //if quit button is clicked.
            {
                Application.Exit(); //Exit the application.
            }
        }

        private void btnAddVan_Click(object sender, EventArgs e)
        {
            vanlist.Add(van1.VanNumber + DateTime.Now.Second);
            // Change the DataSource.
            listBoxSelectVan.DataSource = null;
            listBoxSelectVan.DataSource = vanlist;
            listBoxPUAllocate.DataSource = null;
            listBoxPUAllocate.DataSource = vanlist;
            listBoxDAllocate.DataSource = null;
            listBoxDAllocate.DataSource = vanlist;
            listBoxVanVisits.DataSource = null;
            listBoxVanVisits.DataSource = vanlist;
            btnAddVan.Enabled = true;
        }

        private void btnDeleteVan_Click(object sender, EventArgs e)
        {
            // The Remove button was clicked.
            int selectedIndex = listBoxSelectVan.SelectedIndex;
            try
            {
                // Remove the item in the List.
                vanlist.RemoveAt(selectedIndex);
            }
            catch
            {
                listBoxSelectVan.DataSource = null;
                listBoxSelectVan.DataSource = vanlist;
                if (listBoxSelectVan.Items.Count == 0)
                {
                    btnDeleteVan.Enabled = false;
                }
            }
        }
        // SHOW SUMMARY:
        private void btnSummary_Click(object sender, EventArgs e)
        {
            string[] items = new string[listBoxSummary.Items.Count];
            listBoxSummary.Items.CopyTo(items, 0);
            List<string> summarylist = new List<string>(items);
            // Apply user input to the summary box.
            summarylist.Add(string.Format("{0},{1},{2},{3},{4},{5}, {6} ", "PICK UP:", van1.VanNumber, pickup1.CustomerForename, pickup1.CustomerSurname, pickup1.CustomerAddress, pickup1.PickUpName, pickup1.PickUpAddress, pickup1.ArrivalTime));
            summarylist.Add(string.Format("{0},{1},{2},{3},{4},{5}, {6} ", "DELIVERY", van1.VanNumber, delivery1.CustomerForename, delivery1.CustomerSurname, delivery1.CustomerAddress, delivery1.DeliveryName, delivery1.ArrivalTime));
            holdlist.Add(holdlist);
            holdlist1.Add(holdlist1);
            holdlist2.Add(holdlist2);
            holdlist3.Add(holdlist3);
            listBoxSummary.DataSource = summarylist;
            listBoxSummary.Text = summarylist.ToString();
            // Save data to file.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName);
                foreach (object item in listBoxSummary.Items)
                    sw.WriteLine(item.ToString());
                sw.Close();
            }
        }
        // SHOW PICK UP:
        private void btnShowPickUp_Click(object sender, EventArgs e)
        {
            string[] items = new string[listBoxPickUp.Items.Count];
            listBoxPickUp.Items.CopyTo(items, 0);
            List<string> pickuplist = new List<string>(items);
            // Add user input to pickup box.
            listBoxPickUp.Text = pickuplist.ToString();
            pickuplist.Add(string.Format("{0},{1},{2},{3},{4},{5},{6} ", "PICK UP:", van1.VanNumber, pickup1.CustomerForename, pickup1.CustomerSurname, pickup1.CustomerAddress, pickup1.PickUpName, pickup1.PickUpAddress));
            listBoxPickUp.DataSource = pickuplist;
            // Save data to file.
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog2.FileName);
                foreach (object item in listBoxPickUp.Items)
                    sw.WriteLine(item.ToString());
                sw.Close();
            }
        }
        // SHOW DELIVERY:
        private void btnShowDelivery_Click(object sender, EventArgs e)
        {
            string[] items = new string[listBoxShowDelivery.Items.Count];
            listBoxShowDelivery.Items.CopyTo(items, 0);
            List<string> deliverylist = new List<string>(items);
            // Add user input to delivery box.
            deliverylist.Add(string.Format("{0},{1},{2},{3},{4},{5},{6} ", "DELIVERY", van1.VanNumber, delivery1.CustomerForename, delivery1.CustomerSurname, delivery1.CustomerAddress, delivery1.DeliveryName, delivery1.DeliveryAddress));
            listBoxShowDelivery.Text = deliverylist.ToString();
            listBoxShowDelivery.DataSource = deliverylist;
            // Save data to file.
            if (saveFileDialog3.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog3.FileName);
                foreach (object item in listBoxShowDelivery.Items)
                    sw.WriteLine(item.ToString());
                sw.Close();
            }
        }
        // DELETE PICK UP:
        private void btnDeletePickUp_Click(object sender, EventArgs e)
        {
            for (int n = listBoxSummary.Items.Count - 1; n >= 0; --n)
            {
                string removelistitem = "DELIVERY";
                if (listBoxSummary.Items[n].ToString().Contains(removelistitem))
                {
                   holdlist2.Add(listBoxSummary.Items[n].ToString().Contains(removelistitem));
                   listBoxSummary.Items.RemoveAt(n);
                }
                else
                {
                    int selectedIndex = listBoxSummary.SelectedIndex;
                    if (selectedIndex >= 0)
                    listBoxSummary.Items.RemoveAt(selectedIndex);
                    holdlist3.Add(listBoxSummary.Items);
              }
            }
        }
        // DELETE DELIVERY:
        private void btnDeleteDelivery_Click(object sender, EventArgs e)
        {
            for (int n = listBoxSummary.Items.Count - 1; n >= 0; --n)
            {
                string removelistitem = "PICK UP";
                if (listBoxSummary.Items[n].ToString().Contains(removelistitem))
                {
                     holdlist.Add(listBoxSummary.Items[n].ToString().Contains(removelistitem));
                     listBoxSummary.Items.RemoveAt(n);
                }
                else
                {
                    int selectedIndex = listBoxSummary.SelectedIndex;
                    if (selectedIndex >= 0)
                    listBoxSummary.Items.RemoveAt(selectedIndex);
                    holdlist1.Add(listBoxSummary.Items);
                    holdlist.Add(holdlist);
                }
            }
        }
        // EDIT PICK UP:
        private void btnEditPickup_Click(object sender, EventArgs e)
        {
            Object selectedItem = listBoxSummary.SelectedItem;
            int selectedIndex = listBoxSummary.SelectedIndex;
            string editpickup = "PICK UP:" + "" + van1.VanNumber + "" + pickup1.CustomerForename + "" + pickup1.CustomerSurname + "" + pickup1.CustomerAddress + "" + pickup1.PickUpName + "" + pickup1.PickUpAddress;
            listBoxSummary.DataSource = null;
            int listBoxItemIndex = listBoxSummary.SelectedIndex;
            listBoxSummary.Items[listBoxItemIndex] = editpickup;
        }
        // EDIT DELIVERY:
        private void btnEditDelivery_Click(object sender, EventArgs e)
        {
            Object selectedItem = listBoxSummary.SelectedItem;
            int selectedIndex = listBoxSummary.SelectedIndex;
            string editdelivery = "DELIVERY:" + van1.VanNumber + delivery1.CustomerForename + delivery1.CustomerSurname + delivery1.CustomerAddress + delivery1.DeliveryName + delivery1.DeliveryAddress;
            listBoxSummary.DataSource = null;
            int listBoxItemIndex = listBoxSummary.SelectedIndex;
            listBoxSummary.Items[listBoxItemIndex] = editdelivery;
        }
        // VAN VISITS: Show visits allocated to a certain van.
        private void btnVanVisits_Click(object sender, EventArgs e)
        { 
            listBoxSummary.DataSource = null;
            Object selectedItem = listBoxVanVisits.SelectedItem;
            int selectedIndex = listBoxVanVisits.SelectedIndex;
            RTxtBoxVanVisits.Text = selectedItem.ToString();
            //for (int n = listBoxSummary.Items.Count - 1; n >= 0; --n)
            //{
                if (listBoxSummary.Items.Contains("002"))
                {
                    RTxtBoxVanVisits.Text = listBoxSummary.SelectedItem.ToString();
                    summarylist.Add(string.Format("{0},{1},{2},{3},{4},{5}, {6} ", "PICK UP:", van1.VanNumber, pickup1.CustomerForename, pickup1.CustomerSurname, pickup1.CustomerAddress, pickup1.PickUpName, pickup1.PickUpAddress));
                    summarylist.Add(string.Format("{0},{1},{2},{3},{4},{5}, {6} ", "DELIVERY", van1.VanNumber, delivery1.CustomerForename, delivery1.CustomerSurname, delivery1.CustomerAddress, delivery1.DeliveryName, delivery1.DeliveryAddress));
                  }
                   }           
                    }    
                     }
            
        
    
  

          
           
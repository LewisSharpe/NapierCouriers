namespace Napier_Couriers
{
    partial class FormNapierCouriers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddNewPickUp = new System.Windows.Forms.Button();
            this.lblPUForename = new System.Windows.Forms.Label();
            this.RTxtBoxPUForename = new System.Windows.Forms.RichTextBox();
            this.lblPUSurname = new System.Windows.Forms.Label();
            this.RTxtBoxPUSurname = new System.Windows.Forms.RichTextBox();
            this.lblPUAddress = new System.Windows.Forms.Label();
            this.RTxtBoxPUAddress = new System.Windows.Forms.RichTextBox();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.RTxtBoxPUATime = new System.Windows.Forms.RichTextBox();
            this.lblPickUpName = new System.Windows.Forms.Label();
            this.RTxtBoxPUDName = new System.Windows.Forms.RichTextBox();
            this.lblPUTitle = new System.Windows.Forms.Label();
            this.lblPUSummary = new System.Windows.Forms.Label();
            this.lblDSummary = new System.Windows.Forms.Label();
            this.lblDeliveryTitle = new System.Windows.Forms.Label();
            this.RTxtBoxDeName = new System.Windows.Forms.RichTextBox();
            this.lblDeliveryName = new System.Windows.Forms.Label();
            this.RTxtBoxDATime = new System.Windows.Forms.RichTextBox();
            this.lblATime = new System.Windows.Forms.Label();
            this.RTxtBoxDAddress = new System.Windows.Forms.RichTextBox();
            this.lblDAddress = new System.Windows.Forms.Label();
            this.RTxtBoxDSurname = new System.Windows.Forms.RichTextBox();
            this.lblDSurname = new System.Windows.Forms.Label();
            this.RTxtBoxDForename = new System.Windows.Forms.RichTextBox();
            this.lblDForename = new System.Windows.Forms.Label();
            this.btnAddDelivery = new System.Windows.Forms.Button();
            this.lblPUAllocateVan = new System.Windows.Forms.Label();
            this.lblDAllocateVan = new System.Windows.Forms.Label();
            this.listBoxSelectVan = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnDeleteVan = new System.Windows.Forms.Button();
            this.lblSelectVan = new System.Windows.Forms.Label();
            this.lblQuit = new System.Windows.Forms.Label();
            this.listBoxPUAllocate = new System.Windows.Forms.ListBox();
            this.listBoxDAllocate = new System.Windows.Forms.ListBox();
            this.lblPUVanAllocated = new System.Windows.Forms.Label();
            this.RTxtBoxPUVanAllocated = new System.Windows.Forms.RichTextBox();
            this.RTxtBoxDVanAllocated = new System.Windows.Forms.RichTextBox();
            this.lblDVanAllocated = new System.Windows.Forms.Label();
            this.listBoxSummary = new System.Windows.Forms.ListBox();
            this.lblPUDlistBox = new System.Windows.Forms.Label();
            this.btnAddVan = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.RTxtBoxPUDAddress = new System.Windows.Forms.RichTextBox();
            this.lblPickUpAddress = new System.Windows.Forms.Label();
            this.RTxtBoxDeAddress = new System.Windows.Forms.RichTextBox();
            this.lblDelivery2Name = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.listBoxPickUp = new System.Windows.Forms.ListBox();
            this.lblListBoxPickUp = new System.Windows.Forms.Label();
            this.btnShowPickUp = new System.Windows.Forms.Button();
            this.btnShowDelivery = new System.Windows.Forms.Button();
            this.lblListBoxDelivery = new System.Windows.Forms.Label();
            this.listBoxShowDelivery = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxVanVisits = new System.Windows.Forms.ListBox();
            this.RTxtBoxVanVisits = new System.Windows.Forms.RichTextBox();
            this.btnDeletePickUp = new System.Windows.Forms.Button();
            this.btnDeleteDelivery = new System.Windows.Forms.Button();
            this.btnEditPickup = new System.Windows.Forms.Button();
            this.btnEditDelivery = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnVanVisits = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog3 = new System.Windows.Forms.SaveFileDialog();
            this.lblPUNote = new System.Windows.Forms.Label();
            this.lblDNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(504, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "NAPIER COURIERS.";
            // 
            // btnAddNewPickUp
            // 
            this.btnAddNewPickUp.Location = new System.Drawing.Point(95, 487);
            this.btnAddNewPickUp.Name = "btnAddNewPickUp";
            this.btnAddNewPickUp.Size = new System.Drawing.Size(131, 25);
            this.btnAddNewPickUp.TabIndex = 1;
            this.btnAddNewPickUp.Text = "Add New Pick Up.";
            this.btnAddNewPickUp.UseVisualStyleBackColor = true;
            this.btnAddNewPickUp.Click += new System.EventHandler(this.btnAddNewPickUp_Click);
            // 
            // lblPUForename
            // 
            this.lblPUForename.AutoSize = true;
            this.lblPUForename.Location = new System.Drawing.Point(33, 109);
            this.lblPUForename.Name = "lblPUForename";
            this.lblPUForename.Size = new System.Drawing.Size(123, 14);
            this.lblPUForename.TabIndex = 2;
            this.lblPUForename.Text = "Customer forename:";
            this.lblPUForename.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RTxtBoxPUForename
            // 
            this.RTxtBoxPUForename.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBoxPUForename.Location = new System.Drawing.Point(162, 109);
            this.RTxtBoxPUForename.Name = "RTxtBoxPUForename";
            this.RTxtBoxPUForename.Size = new System.Drawing.Size(129, 21);
            this.RTxtBoxPUForename.TabIndex = 3;
            this.RTxtBoxPUForename.Text = "";
            // 
            // lblPUSurname
            // 
            this.lblPUSurname.AutoSize = true;
            this.lblPUSurname.Location = new System.Drawing.Point(33, 144);
            this.lblPUSurname.Name = "lblPUSurname";
            this.lblPUSurname.Size = new System.Drawing.Size(119, 14);
            this.lblPUSurname.TabIndex = 4;
            this.lblPUSurname.Text = "Customer surname:";
            // 
            // RTxtBoxPUSurname
            // 
            this.RTxtBoxPUSurname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBoxPUSurname.Location = new System.Drawing.Point(162, 137);
            this.RTxtBoxPUSurname.Name = "RTxtBoxPUSurname";
            this.RTxtBoxPUSurname.Size = new System.Drawing.Size(129, 21);
            this.RTxtBoxPUSurname.TabIndex = 5;
            this.RTxtBoxPUSurname.Text = "";
            // 
            // lblPUAddress
            // 
            this.lblPUAddress.AutoSize = true;
            this.lblPUAddress.Location = new System.Drawing.Point(33, 172);
            this.lblPUAddress.Name = "lblPUAddress";
            this.lblPUAddress.Size = new System.Drawing.Size(115, 14);
            this.lblPUAddress.TabIndex = 6;
            this.lblPUAddress.Text = "Customer address:";
            // 
            // RTxtBoxPUAddress
            // 
            this.RTxtBoxPUAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBoxPUAddress.Location = new System.Drawing.Point(162, 167);
            this.RTxtBoxPUAddress.Name = "RTxtBoxPUAddress";
            this.RTxtBoxPUAddress.Size = new System.Drawing.Size(129, 55);
            this.RTxtBoxPUAddress.TabIndex = 7;
            this.RTxtBoxPUAddress.Text = "";
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Location = new System.Drawing.Point(31, 379);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(77, 14);
            this.lblArrivalTime.TabIndex = 8;
            this.lblArrivalTime.Text = "Arrival Time:";
            // 
            // RTxtBoxPUATime
            // 
            this.RTxtBoxPUATime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBoxPUATime.Location = new System.Drawing.Point(160, 372);
            this.RTxtBoxPUATime.Name = "RTxtBoxPUATime";
            this.RTxtBoxPUATime.Size = new System.Drawing.Size(129, 21);
            this.RTxtBoxPUATime.TabIndex = 9;
            this.RTxtBoxPUATime.Text = "";
            // 
            // lblPickUpName
            // 
            this.lblPickUpName.AutoSize = true;
            this.lblPickUpName.Location = new System.Drawing.Point(35, 236);
            this.lblPickUpName.Name = "lblPickUpName";
            this.lblPickUpName.Size = new System.Drawing.Size(84, 14);
            this.lblPickUpName.TabIndex = 10;
            this.lblPickUpName.Text = "Pick up name:";
            this.lblPickUpName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RTxtBoxPUDName
            // 
            this.RTxtBoxPUDName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBoxPUDName.Location = new System.Drawing.Point(162, 232);
            this.RTxtBoxPUDName.Name = "RTxtBoxPUDName";
            this.RTxtBoxPUDName.Size = new System.Drawing.Size(129, 21);
            this.RTxtBoxPUDName.TabIndex = 11;
            this.RTxtBoxPUDName.Text = "";
            // 
            // lblPUTitle
            // 
            this.lblPUTitle.AutoSize = true;
            this.lblPUTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUTitle.Location = new System.Drawing.Point(122, 68);
            this.lblPUTitle.Name = "lblPUTitle";
            this.lblPUTitle.Size = new System.Drawing.Size(74, 16);
            this.lblPUTitle.TabIndex = 12;
            this.lblPUTitle.Text = "PICK UPS:";
            this.lblPUTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPUSummary
            // 
            this.lblPUSummary.AutoSize = true;
            this.lblPUSummary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUSummary.Location = new System.Drawing.Point(50, 589);
            this.lblPUSummary.Name = "lblPUSummary";
            this.lblPUSummary.Size = new System.Drawing.Size(121, 16);
            this.lblPUSummary.TabIndex = 13;
            this.lblPUSummary.Text = "Pick up summary.";
            this.lblPUSummary.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPUSummary.Visible = false;
            // 
            // lblDSummary
            // 
            this.lblDSummary.AutoSize = true;
            this.lblDSummary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSummary.Location = new System.Drawing.Point(361, 589);
            this.lblDSummary.Name = "lblDSummary";
            this.lblDSummary.Size = new System.Drawing.Size(126, 16);
            this.lblDSummary.TabIndex = 26;
            this.lblDSummary.Text = "Delivery summary.";
            this.lblDSummary.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDSummary.Visible = false;
            // 
            // lblDeliveryTitle
            // 
            this.lblDeliveryTitle.AutoSize = true;
            this.lblDeliveryTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryTitle.Location = new System.Drawing.Point(437, 68);
            this.lblDeliveryTitle.Name = "lblDeliveryTitle";
            this.lblDeliveryTitle.Size = new System.Drawing.Size(88, 16);
            this.lblDeliveryTitle.TabIndex = 25;
            this.lblDeliveryTitle.Text = "DELIVERIES:";
            this.lblDeliveryTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RTxtBoxDeName
            // 
            this.RTxtBoxDeName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBoxDeName.Location = new System.Drawing.Point(475, 232);
            this.RTxtBoxDeName.Name = "RTxtBoxDeName";
            this.RTxtBoxDeName.Size = new System.Drawing.Size(129, 21);
            this.RTxtBoxDeName.TabIndex = 24;
            this.RTxtBoxDeName.Text = "";
            // 
            // lblDeliveryName
            // 
            this.lblDeliveryName.AutoSize = true;
            this.lblDeliveryName.Location = new System.Drawing.Point(346, 232);
            this.lblDeliveryName.Name = "lblDeliveryName";
            this.lblDeliveryName.Size = new System.Drawing.Size(88, 14);
            this.lblDeliveryName.TabIndex = 23;
            this.lblDeliveryName.Text = "Delivery name:";
            this.lblDeliveryName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RTxtBoxDATime
            // 
            this.RTxtBoxDATime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBoxDATime.Location = new System.Drawing.Point(473, 365);
            this.RTxtBoxDATime.Name = "RTxtBoxDATime";
            this.RTxtBoxDATime.Size = new System.Drawing.Size(129, 21);
            this.RTxtBoxDATime.TabIndex = 22;
            this.RTxtBoxDATime.Text = "";
            // 
            // lblATime
            // 
            this.lblATime.AutoSize = true;
            this.lblATime.Location = new System.Drawing.Point(344, 372);
            this.lblATime.Name = "lblATime";
            this.lblATime.Size = new System.Drawing.Size(77, 14);
            this.lblATime.TabIndex = 21;
            this.lblATime.Text = "Arrival Time:";
            // 
            // RTxtBoxDAddress
            // 
            this.RTxtBoxDAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBoxDAddress.Location = new System.Drawing.Point(475, 165);
            this.RTxtBoxDAddress.Name = "RTxtBoxDAddress";
            this.RTxtBoxDAddress.Size = new System.Drawing.Size(129, 55);
            this.RTxtBoxDAddress.TabIndex = 20;
            this.RTxtBoxDAddress.Text = "";
            // 
            // lblDAddress
            // 
            this.lblDAddress.AutoSize = true;
            this.lblDAddress.Location = new System.Drawing.Point(346, 172);
            this.lblDAddress.Name = "lblDAddress";
            this.lblDAddress.Size = new System.Drawing.Size(115, 14);
            this.lblDAddress.TabIndex = 19;
            this.lblDAddress.Text = "Customer address:";
            // 
            // RTxtBoxDSurname
            // 
            this.RTxtBoxDSurname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBoxDSurname.Location = new System.Drawing.Point(475, 135);
            this.RTxtBoxDSurname.Name = "RTxtBoxDSurname";
            this.RTxtBoxDSurname.Size = new System.Drawing.Size(129, 21);
            this.RTxtBoxDSurname.TabIndex = 18;
            this.RTxtBoxDSurname.Text = "";
            // 
            // lblDSurname
            // 
            this.lblDSurname.AutoSize = true;
            this.lblDSurname.Location = new System.Drawing.Point(346, 142);
            this.lblDSurname.Name = "lblDSurname";
            this.lblDSurname.Size = new System.Drawing.Size(119, 14);
            this.lblDSurname.TabIndex = 17;
            this.lblDSurname.Text = "Customer surname:";
            // 
            // RTxtBoxDForename
            // 
            this.RTxtBoxDForename.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBoxDForename.Location = new System.Drawing.Point(475, 107);
            this.RTxtBoxDForename.Name = "RTxtBoxDForename";
            this.RTxtBoxDForename.Size = new System.Drawing.Size(129, 21);
            this.RTxtBoxDForename.TabIndex = 16;
            this.RTxtBoxDForename.Text = "";
            // 
            // lblDForename
            // 
            this.lblDForename.AutoSize = true;
            this.lblDForename.Location = new System.Drawing.Point(346, 107);
            this.lblDForename.Name = "lblDForename";
            this.lblDForename.Size = new System.Drawing.Size(123, 14);
            this.lblDForename.TabIndex = 15;
            this.lblDForename.Text = "Customer forename:";
            this.lblDForename.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddDelivery
            // 
            this.btnAddDelivery.Location = new System.Drawing.Point(413, 487);
            this.btnAddDelivery.Name = "btnAddDelivery";
            this.btnAddDelivery.Size = new System.Drawing.Size(131, 25);
            this.btnAddDelivery.TabIndex = 14;
            this.btnAddDelivery.Text = "Add New Delivery.";
            this.btnAddDelivery.UseVisualStyleBackColor = true;
            this.btnAddDelivery.Click += new System.EventHandler(this.btnAddDelivery_Click);
            // 
            // lblPUAllocateVan
            // 
            this.lblPUAllocateVan.AutoSize = true;
            this.lblPUAllocateVan.Location = new System.Drawing.Point(32, 409);
            this.lblPUAllocateVan.Name = "lblPUAllocateVan";
            this.lblPUAllocateVan.Size = new System.Drawing.Size(76, 14);
            this.lblPUAllocateVan.TabIndex = 27;
            this.lblPUAllocateVan.Text = "Allocate van:";
            // 
            // lblDAllocateVan
            // 
            this.lblDAllocateVan.AutoSize = true;
            this.lblDAllocateVan.Location = new System.Drawing.Point(344, 409);
            this.lblDAllocateVan.Name = "lblDAllocateVan";
            this.lblDAllocateVan.Size = new System.Drawing.Size(76, 14);
            this.lblDAllocateVan.TabIndex = 29;
            this.lblDAllocateVan.Text = "Allocate van:";
            // 
            // listBoxSelectVan
            // 
            this.listBoxSelectVan.FormattingEnabled = true;
            this.listBoxSelectVan.ItemHeight = 14;
            this.listBoxSelectVan.Location = new System.Drawing.Point(716, 125);
            this.listBoxSelectVan.Name = "listBoxSelectVan";
            this.listBoxSelectVan.Size = new System.Drawing.Size(120, 88);
            this.listBoxSelectVan.TabIndex = 31;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(524, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 16);
            this.lblDate.TabIndex = 32;
            this.lblDate.Text = "Date.";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(598, 604);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(44, 16);
            this.lblTime.TabIndex = 33;
            this.lblTime.Text = "Time.";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDeleteVan
            // 
            this.btnDeleteVan.Location = new System.Drawing.Point(788, 226);
            this.btnDeleteVan.Name = "btnDeleteVan";
            this.btnDeleteVan.Size = new System.Drawing.Size(84, 25);
            this.btnDeleteVan.TabIndex = 35;
            this.btnDeleteVan.Text = "Delete Van.";
            this.btnDeleteVan.UseVisualStyleBackColor = true;
            this.btnDeleteVan.Click += new System.EventHandler(this.btnDeleteVan_Click);
            // 
            // lblSelectVan
            // 
            this.lblSelectVan.AutoSize = true;
            this.lblSelectVan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectVan.Location = new System.Drawing.Point(730, 90);
            this.lblSelectVan.Name = "lblSelectVan";
            this.lblSelectVan.Size = new System.Drawing.Size(93, 16);
            this.lblSelectVan.TabIndex = 36;
            this.lblSelectVan.Text = "SELECT VAN:";
            this.lblSelectVan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQuit
            // 
            this.lblQuit.AutoSize = true;
            this.lblQuit.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuit.ForeColor = System.Drawing.Color.Red;
            this.lblQuit.Location = new System.Drawing.Point(1195, 8);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(56, 56);
            this.lblQuit.TabIndex = 37;
            this.lblQuit.Text = "X";
            this.lblQuit.Click += new System.EventHandler(this.lblQuit_Click);
            // 
            // listBoxPUAllocate
            // 
            this.listBoxPUAllocate.FormattingEnabled = true;
            this.listBoxPUAllocate.ItemHeight = 14;
            this.listBoxPUAllocate.Location = new System.Drawing.Point(160, 403);
            this.listBoxPUAllocate.Name = "listBoxPUAllocate";
            this.listBoxPUAllocate.Size = new System.Drawing.Size(129, 46);
            this.listBoxPUAllocate.TabIndex = 40;
            // 
            // listBoxDAllocate
            // 
            this.listBoxDAllocate.FormattingEnabled = true;
            this.listBoxDAllocate.ItemHeight = 14;
            this.listBoxDAllocate.Location = new System.Drawing.Point(473, 403);
            this.listBoxDAllocate.Name = "listBoxDAllocate";
            this.listBoxDAllocate.Size = new System.Drawing.Size(129, 46);
            this.listBoxDAllocate.TabIndex = 41;
            // 
            // lblPUVanAllocated
            // 
            this.lblPUVanAllocated.AutoSize = true;
            this.lblPUVanAllocated.Location = new System.Drawing.Point(34, 460);
            this.lblPUVanAllocated.Name = "lblPUVanAllocated";
            this.lblPUVanAllocated.Size = new System.Drawing.Size(83, 14);
            this.lblPUVanAllocated.TabIndex = 42;
            this.lblPUVanAllocated.Text = "Van allocated:";
            // 
            // RTxtBoxPUVanAllocated
            // 
            this.RTxtBoxPUVanAllocated.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBoxPUVanAllocated.Location = new System.Drawing.Point(160, 460);
            this.RTxtBoxPUVanAllocated.Name = "RTxtBoxPUVanAllocated";
            this.RTxtBoxPUVanAllocated.Size = new System.Drawing.Size(129, 21);
            this.RTxtBoxPUVanAllocated.TabIndex = 43;
            this.RTxtBoxPUVanAllocated.Text = "";
            // 
            // RTxtBoxDVanAllocated
            // 
            this.RTxtBoxDVanAllocated.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBoxDVanAllocated.Location = new System.Drawing.Point(473, 455);
            this.RTxtBoxDVanAllocated.Name = "RTxtBoxDVanAllocated";
            this.RTxtBoxDVanAllocated.Size = new System.Drawing.Size(129, 21);
            this.RTxtBoxDVanAllocated.TabIndex = 44;
            this.RTxtBoxDVanAllocated.Text = "";
            // 
            // lblDVanAllocated
            // 
            this.lblDVanAllocated.AutoSize = true;
            this.lblDVanAllocated.Location = new System.Drawing.Point(349, 455);
            this.lblDVanAllocated.Name = "lblDVanAllocated";
            this.lblDVanAllocated.Size = new System.Drawing.Size(83, 14);
            this.lblDVanAllocated.TabIndex = 45;
            this.lblDVanAllocated.Text = "Van allocated:";
            // 
            // listBoxSummary
            // 
            this.listBoxSummary.FormattingEnabled = true;
            this.listBoxSummary.ItemHeight = 14;
            this.listBoxSummary.Location = new System.Drawing.Point(860, 125);
            this.listBoxSummary.Name = "listBoxSummary";
            this.listBoxSummary.Size = new System.Drawing.Size(391, 88);
            this.listBoxSummary.TabIndex = 46;
            // 
            // lblPUDlistBox
            // 
            this.lblPUDlistBox.AutoSize = true;
            this.lblPUDlistBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUDlistBox.Location = new System.Drawing.Point(857, 90);
            this.lblPUDlistBox.Name = "lblPUDlistBox";
            this.lblPUDlistBox.Size = new System.Drawing.Size(301, 16);
            this.lblPUDlistBox.TabIndex = 47;
            this.lblPUDlistBox.Text = "SUMMARY: PICKUPS/DELIVERIES (ALL VANS):";
            this.lblPUDlistBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddVan
            // 
            this.btnAddVan.Location = new System.Drawing.Point(698, 226);
            this.btnAddVan.Name = "btnAddVan";
            this.btnAddVan.Size = new System.Drawing.Size(84, 25);
            this.btnAddVan.TabIndex = 34;
            this.btnAddVan.Text = "Add Van.";
            this.btnAddVan.UseVisualStyleBackColor = true;
            this.btnAddVan.Click += new System.EventHandler(this.btnAddVan_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(982, 225);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(119, 25);
            this.btnSummary.TabIndex = 48;
            this.btnSummary.Text = "Show summary.";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // RTxtBoxPUDAddress
            // 
            this.RTxtBoxPUDAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBoxPUDAddress.Location = new System.Drawing.Point(162, 278);
            this.RTxtBoxPUDAddress.Name = "RTxtBoxPUDAddress";
            this.RTxtBoxPUDAddress.Size = new System.Drawing.Size(129, 55);
            this.RTxtBoxPUDAddress.TabIndex = 49;
            this.RTxtBoxPUDAddress.Text = "";
            // 
            // lblPickUpAddress
            // 
            this.lblPickUpAddress.AutoSize = true;
            this.lblPickUpAddress.Location = new System.Drawing.Point(35, 297);
            this.lblPickUpAddress.Name = "lblPickUpAddress";
            this.lblPickUpAddress.Size = new System.Drawing.Size(96, 14);
            this.lblPickUpAddress.TabIndex = 50;
            this.lblPickUpAddress.Text = "Pick up address";
            this.lblPickUpAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RTxtBoxDeAddress
            // 
            this.RTxtBoxDeAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBoxDeAddress.Location = new System.Drawing.Point(475, 278);
            this.RTxtBoxDeAddress.Name = "RTxtBoxDeAddress";
            this.RTxtBoxDeAddress.Size = new System.Drawing.Size(129, 55);
            this.RTxtBoxDeAddress.TabIndex = 51;
            this.RTxtBoxDeAddress.Text = "";
            // 
            // lblDelivery2Name
            // 
            this.lblDelivery2Name.AutoSize = true;
            this.lblDelivery2Name.Location = new System.Drawing.Point(346, 297);
            this.lblDelivery2Name.Name = "lblDelivery2Name";
            this.lblDelivery2Name.Size = new System.Drawing.Size(103, 14);
            this.lblDelivery2Name.TabIndex = 52;
            this.lblDelivery2Name.Text = "Delivery address:";
            this.lblDelivery2Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(162, 255);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 18);
            this.checkBox1.TabIndex = 53;
            this.checkBox1.Text = "Same as customer name.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(162, 339);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(182, 18);
            this.checkBox2.TabIndex = 54;
            this.checkBox2.Text = "Same as customer address.";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(475, 254);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(167, 18);
            this.checkBox3.TabIndex = 55;
            this.checkBox3.Text = "Same as customer name.";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(475, 339);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(182, 18);
            this.checkBox4.TabIndex = 56;
            this.checkBox4.Text = "Same as customer address.";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // listBoxPickUp
            // 
            this.listBoxPickUp.FormattingEnabled = true;
            this.listBoxPickUp.ItemHeight = 14;
            this.listBoxPickUp.Location = new System.Drawing.Point(716, 297);
            this.listBoxPickUp.Name = "listBoxPickUp";
            this.listBoxPickUp.Size = new System.Drawing.Size(253, 88);
            this.listBoxPickUp.TabIndex = 57;
            // 
            // lblListBoxPickUp
            // 
            this.lblListBoxPickUp.AutoSize = true;
            this.lblListBoxPickUp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListBoxPickUp.Location = new System.Drawing.Point(754, 267);
            this.lblListBoxPickUp.Name = "lblListBoxPickUp";
            this.lblListBoxPickUp.Size = new System.Drawing.Size(168, 16);
            this.lblListBoxPickUp.TabIndex = 58;
            this.lblListBoxPickUp.Text = "ALL CURRENT PICK UPS:";
            this.lblListBoxPickUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnShowPickUp
            // 
            this.btnShowPickUp.Location = new System.Drawing.Point(757, 400);
            this.btnShowPickUp.Name = "btnShowPickUp";
            this.btnShowPickUp.Size = new System.Drawing.Size(115, 23);
            this.btnShowPickUp.TabIndex = 59;
            this.btnShowPickUp.Text = "Show Pickups.";
            this.btnShowPickUp.UseVisualStyleBackColor = true;
            this.btnShowPickUp.Click += new System.EventHandler(this.btnShowPickUp_Click);
            // 
            // btnShowDelivery
            // 
            this.btnShowDelivery.Location = new System.Drawing.Point(1055, 400);
            this.btnShowDelivery.Name = "btnShowDelivery";
            this.btnShowDelivery.Size = new System.Drawing.Size(115, 23);
            this.btnShowDelivery.TabIndex = 62;
            this.btnShowDelivery.Text = "Show Deliveries.";
            this.btnShowDelivery.UseVisualStyleBackColor = true;
            this.btnShowDelivery.Click += new System.EventHandler(this.btnShowDelivery_Click);
            // 
            // lblListBoxDelivery
            // 
            this.lblListBoxDelivery.AutoSize = true;
            this.lblListBoxDelivery.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListBoxDelivery.Location = new System.Drawing.Point(1010, 267);
            this.lblListBoxDelivery.Name = "lblListBoxDelivery";
            this.lblListBoxDelivery.Size = new System.Drawing.Size(182, 16);
            this.lblListBoxDelivery.TabIndex = 61;
            this.lblListBoxDelivery.Text = "ALL CURRENT DELIVERIES:";
            this.lblListBoxDelivery.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxShowDelivery
            // 
            this.listBoxShowDelivery.FormattingEnabled = true;
            this.listBoxShowDelivery.ItemHeight = 14;
            this.listBoxShowDelivery.Location = new System.Drawing.Point(986, 297);
            this.listBoxShowDelivery.Name = "listBoxShowDelivery";
            this.listBoxShowDelivery.Size = new System.Drawing.Size(253, 88);
            this.listBoxShowDelivery.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(734, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "INDIVIDUAL VAN VISITS:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxVanVisits
            // 
            this.listBoxVanVisits.FormattingEnabled = true;
            this.listBoxVanVisits.ItemHeight = 14;
            this.listBoxVanVisits.Location = new System.Drawing.Point(733, 466);
            this.listBoxVanVisits.Name = "listBoxVanVisits";
            this.listBoxVanVisits.Size = new System.Drawing.Size(165, 32);
            this.listBoxVanVisits.TabIndex = 64;
            // 
            // RTxtBoxVanVisits
            // 
            this.RTxtBoxVanVisits.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtBoxVanVisits.Location = new System.Drawing.Point(733, 506);
            this.RTxtBoxVanVisits.Name = "RTxtBoxVanVisits";
            this.RTxtBoxVanVisits.Size = new System.Drawing.Size(165, 55);
            this.RTxtBoxVanVisits.TabIndex = 65;
            this.RTxtBoxVanVisits.Text = "";
            // 
            // btnDeletePickUp
            // 
            this.btnDeletePickUp.Location = new System.Drawing.Point(986, 507);
            this.btnDeletePickUp.Name = "btnDeletePickUp";
            this.btnDeletePickUp.Size = new System.Drawing.Size(115, 23);
            this.btnDeletePickUp.TabIndex = 67;
            this.btnDeletePickUp.Text = "Delete Pickup.\r\n";
            this.btnDeletePickUp.UseVisualStyleBackColor = true;
            this.btnDeletePickUp.Click += new System.EventHandler(this.btnDeletePickUp_Click);
            // 
            // btnDeleteDelivery
            // 
            this.btnDeleteDelivery.Location = new System.Drawing.Point(1107, 506);
            this.btnDeleteDelivery.Name = "btnDeleteDelivery";
            this.btnDeleteDelivery.Size = new System.Drawing.Size(115, 23);
            this.btnDeleteDelivery.TabIndex = 68;
            this.btnDeleteDelivery.Text = "Delete Delivery.";
            this.btnDeleteDelivery.UseVisualStyleBackColor = true;
            this.btnDeleteDelivery.Click += new System.EventHandler(this.btnDeleteDelivery_Click);
            // 
            // btnEditPickup
            // 
            this.btnEditPickup.Location = new System.Drawing.Point(986, 536);
            this.btnEditPickup.Name = "btnEditPickup";
            this.btnEditPickup.Size = new System.Drawing.Size(115, 23);
            this.btnEditPickup.TabIndex = 69;
            this.btnEditPickup.Text = "Edit Pickup.";
            this.btnEditPickup.UseVisualStyleBackColor = true;
            this.btnEditPickup.Click += new System.EventHandler(this.btnEditPickup_Click);
            // 
            // btnEditDelivery
            // 
            this.btnEditDelivery.Location = new System.Drawing.Point(1107, 535);
            this.btnEditDelivery.Name = "btnEditDelivery";
            this.btnEditDelivery.Size = new System.Drawing.Size(115, 23);
            this.btnEditDelivery.TabIndex = 70;
            this.btnEditDelivery.Text = "Edit Delivery.";
            this.btnEditDelivery.UseVisualStyleBackColor = true;
            this.btnEditDelivery.Click += new System.EventHandler(this.btnEditDelivery_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "C:\\Users\\Lewis\\Documents\\Software Development 2\\CourseworkP2\\SystemData";
            // 
            // btnVanVisits
            // 
            this.btnVanVisits.Location = new System.Drawing.Point(757, 567);
            this.btnVanVisits.Name = "btnVanVisits";
            this.btnVanVisits.Size = new System.Drawing.Size(115, 23);
            this.btnVanVisits.TabIndex = 71;
            this.btnVanVisits.Text = "Show Visits.";
            this.btnVanVisits.UseVisualStyleBackColor = true;
            this.btnVanVisits.Click += new System.EventHandler(this.btnVanVisits_Click);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileName = "C:\\Users\\Lewis\\Documents\\Software Development 2\\CourseworkP2\\PICKUP";
            // 
            // saveFileDialog3
            // 
            this.saveFileDialog3.FileName = "C:\\Users\\Lewis\\Documents\\Software Development 2\\CourseworkP2\\DELIVERY";
            // 
            // lblPUNote
            // 
            this.lblPUNote.AutoSize = true;
            this.lblPUNote.Location = new System.Drawing.Point(92, 540);
            this.lblPUNote.Name = "lblPUNote";
            this.lblPUNote.Size = new System.Drawing.Size(197, 14);
            this.lblPUNote.TabIndex = 72;
            this.lblPUNote.Text = "Please press button again to save.";
            this.lblPUNote.Visible = false;
            // 
            // lblDNote
            // 
            this.lblDNote.AutoSize = true;
            this.lblDNote.Location = new System.Drawing.Point(419, 535);
            this.lblDNote.Name = "lblDNote";
            this.lblDNote.Size = new System.Drawing.Size(197, 14);
            this.lblDNote.TabIndex = 73;
            this.lblDNote.Text = "Please press button again to save.";
            this.lblDNote.Visible = false;
            // 
            // FormNapierCouriers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 629);
            this.Controls.Add(this.lblDNote);
            this.Controls.Add(this.lblPUNote);
            this.Controls.Add(this.btnVanVisits);
            this.Controls.Add(this.btnEditDelivery);
            this.Controls.Add(this.btnEditPickup);
            this.Controls.Add(this.btnDeleteDelivery);
            this.Controls.Add(this.btnDeletePickUp);
            this.Controls.Add(this.RTxtBoxVanVisits);
            this.Controls.Add(this.listBoxVanVisits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowDelivery);
            this.Controls.Add(this.lblListBoxDelivery);
            this.Controls.Add(this.listBoxShowDelivery);
            this.Controls.Add(this.btnShowPickUp);
            this.Controls.Add(this.lblListBoxPickUp);
            this.Controls.Add(this.listBoxPickUp);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblDelivery2Name);
            this.Controls.Add(this.RTxtBoxDeAddress);
            this.Controls.Add(this.lblPickUpAddress);
            this.Controls.Add(this.RTxtBoxPUDAddress);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.lblPUDlistBox);
            this.Controls.Add(this.listBoxSummary);
            this.Controls.Add(this.lblDVanAllocated);
            this.Controls.Add(this.RTxtBoxDVanAllocated);
            this.Controls.Add(this.RTxtBoxPUVanAllocated);
            this.Controls.Add(this.lblPUVanAllocated);
            this.Controls.Add(this.listBoxDAllocate);
            this.Controls.Add(this.listBoxPUAllocate);
            this.Controls.Add(this.lblQuit);
            this.Controls.Add(this.lblSelectVan);
            this.Controls.Add(this.btnDeleteVan);
            this.Controls.Add(this.btnAddVan);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.listBoxSelectVan);
            this.Controls.Add(this.lblDAllocateVan);
            this.Controls.Add(this.lblPUAllocateVan);
            this.Controls.Add(this.lblDSummary);
            this.Controls.Add(this.lblDeliveryTitle);
            this.Controls.Add(this.RTxtBoxDeName);
            this.Controls.Add(this.lblDeliveryName);
            this.Controls.Add(this.RTxtBoxDATime);
            this.Controls.Add(this.lblATime);
            this.Controls.Add(this.RTxtBoxDAddress);
            this.Controls.Add(this.lblDAddress);
            this.Controls.Add(this.RTxtBoxDSurname);
            this.Controls.Add(this.lblDSurname);
            this.Controls.Add(this.RTxtBoxDForename);
            this.Controls.Add(this.lblDForename);
            this.Controls.Add(this.btnAddDelivery);
            this.Controls.Add(this.lblPUSummary);
            this.Controls.Add(this.lblPUTitle);
            this.Controls.Add(this.RTxtBoxPUDName);
            this.Controls.Add(this.lblPickUpName);
            this.Controls.Add(this.RTxtBoxPUATime);
            this.Controls.Add(this.lblArrivalTime);
            this.Controls.Add(this.RTxtBoxPUAddress);
            this.Controls.Add(this.lblPUAddress);
            this.Controls.Add(this.RTxtBoxPUSurname);
            this.Controls.Add(this.lblPUSurname);
            this.Controls.Add(this.RTxtBoxPUForename);
            this.Controls.Add(this.lblPUForename);
            this.Controls.Add(this.btnAddNewPickUp);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "FormNapierCouriers";
            this.Text = "NAPIER COURIERS.";
            this.Load += new System.EventHandler(this.FormNapierCouriers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddNewPickUp;
        private System.Windows.Forms.Label lblPUForename;
        private System.Windows.Forms.RichTextBox RTxtBoxPUForename;
        private System.Windows.Forms.Label lblPUSurname;
        private System.Windows.Forms.RichTextBox RTxtBoxPUSurname;
        private System.Windows.Forms.Label lblPUAddress;
        private System.Windows.Forms.RichTextBox RTxtBoxPUAddress;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.RichTextBox RTxtBoxPUATime;
        private System.Windows.Forms.Label lblPickUpName;
        private System.Windows.Forms.Label lblPUTitle;
        private System.Windows.Forms.Label lblPUSummary;
        private System.Windows.Forms.Label lblDSummary;
        private System.Windows.Forms.Label lblDeliveryTitle;
        private System.Windows.Forms.RichTextBox RTxtBoxDeName;
        private System.Windows.Forms.Label lblDeliveryName;
        private System.Windows.Forms.RichTextBox RTxtBoxDATime;
        private System.Windows.Forms.Label lblATime;
        private System.Windows.Forms.RichTextBox RTxtBoxDAddress;
        private System.Windows.Forms.Label lblDAddress;
        private System.Windows.Forms.RichTextBox RTxtBoxDSurname;
        private System.Windows.Forms.Label lblDSurname;
        private System.Windows.Forms.RichTextBox RTxtBoxDForename;
        private System.Windows.Forms.Label lblDForename;
        private System.Windows.Forms.Button btnAddDelivery;
        private System.Windows.Forms.Label lblPUAllocateVan;
        private System.Windows.Forms.Label lblDAllocateVan;
        private System.Windows.Forms.ListBox listBoxSelectVan;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnDeleteVan;
        private System.Windows.Forms.Label lblSelectVan;
        public System.Windows.Forms.RichTextBox RTxtBoxPUDName;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.ListBox listBoxPUAllocate;
        private System.Windows.Forms.ListBox listBoxDAllocate;
        private System.Windows.Forms.Label lblPUVanAllocated;
        private System.Windows.Forms.RichTextBox RTxtBoxPUVanAllocated;
        private System.Windows.Forms.RichTextBox RTxtBoxDVanAllocated;
        private System.Windows.Forms.Label lblDVanAllocated;
        private System.Windows.Forms.ListBox listBoxSummary;
        private System.Windows.Forms.Label lblPUDlistBox;
        private System.Windows.Forms.Button btnAddVan;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.RichTextBox RTxtBoxPUDAddress;
        private System.Windows.Forms.Label lblPickUpAddress;
        private System.Windows.Forms.RichTextBox RTxtBoxDeAddress;
        private System.Windows.Forms.Label lblDelivery2Name;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ListBox listBoxPickUp;
        private System.Windows.Forms.Label lblListBoxPickUp;
        private System.Windows.Forms.Button btnShowPickUp;
        private System.Windows.Forms.Button btnShowDelivery;
        private System.Windows.Forms.Label lblListBoxDelivery;
        private System.Windows.Forms.ListBox listBoxShowDelivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxVanVisits;
        private System.Windows.Forms.RichTextBox RTxtBoxVanVisits;
        private System.Windows.Forms.Button btnDeletePickUp;
        private System.Windows.Forms.Button btnDeleteDelivery;
        private System.Windows.Forms.Button btnEditPickup;
        private System.Windows.Forms.Button btnEditDelivery;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnVanVisits;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog3;
        private System.Windows.Forms.Label lblPUNote;
        private System.Windows.Forms.Label lblDNote;
    }
}


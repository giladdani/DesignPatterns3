using System;

namespace FacebookDeskAppUI
{
    public partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label labelFriendBirthday;
            System.Windows.Forms.Label labelFriendEmail;
            System.Windows.Forms.Label labelFriendMiddleName;
            System.Windows.Forms.Label labelFriendName;
            System.Windows.Forms.Label LabelFriendReligion;
            System.Windows.Forms.Label labelFriendUsername;
            System.Windows.Forms.Label labelGroupDescription;
            System.Windows.Forms.Label labelGroupName;
            this.pictureBoxProfilePhoto = new System.Windows.Forms.PictureBox();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.tabGroups = new System.Windows.Forms.TabPage();
            this.labelGroupDescriptionVal = new System.Windows.Forms.Label();
            this.labelGroupNameVal = new System.Windows.Forms.Label();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.labelListOfGroups = new System.Windows.Forms.Label();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabFriends = new System.Windows.Forms.TabPage();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelListOfFriends = new System.Windows.Forms.Label();
            this.panelFriendDetails = new System.Windows.Forms.Panel();
            this.labelFriendBirthdayVal = new System.Windows.Forms.Label();
            this.friendsDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFriendUsernameVal = new System.Windows.Forms.Label();
            this.labelFriendReligionVal = new System.Windows.Forms.Label();
            this.labelFriendEmailVal = new System.Windows.Forms.Label();
            this.labelFriendNameVal = new System.Windows.Forms.Label();
            this.labelFriendMiddleNameVal = new System.Windows.Forms.Label();
            this.tabPhotos = new System.Windows.Forms.TabPage();
            this.pictureNormalURLPictureBox = new System.Windows.Forms.PictureBox();
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxPhotos = new System.Windows.Forms.ListBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPosts = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBestHourToPostByComments = new System.Windows.Forms.Button();
            this.labelBestHourToPostVal = new System.Windows.Forms.Label();
            this.buttonBestHourToPostByLikes = new System.Windows.Forms.Button();
            this.panelCreatePost = new System.Windows.Forms.Panel();
            this.richTextBoxCreatePost = new System.Windows.Forms.RichTextBox();
            this.buttonCreatePost = new System.Windows.Forms.Button();
            this.labelCreatePost = new System.Windows.Forms.Label();
            this.comboBoxPostsFilter = new System.Windows.Forms.ComboBox();
            this.labelPostsFilter = new System.Windows.Forms.Label();
            this.labelPostsSubFilter = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.comboBoxPostsSubFilter = new System.Windows.Forms.ComboBox();
            this.panelPost = new System.Windows.Forms.Panel();
            this.panelPostBody = new System.Windows.Forms.Panel();
            this.labelPostBody = new System.Windows.Forms.Label();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPostName = new System.Windows.Forms.Label();
            this.pictureBoxPostPhoto = new System.Windows.Forms.PictureBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelAboutBirthYearVal = new System.Windows.Forms.Label();
            this.labelAboutGenderVal = new System.Windows.Forms.Label();
            this.labelAboutNameVal = new System.Windows.Forms.Label();
            this.labelAboutGender = new System.Windows.Forms.Label();
            this.labelAboutBirthYear = new System.Windows.Forms.Label();
            this.labelAboutName = new System.Windows.Forms.Label();
            this.pictureBoxAboutPhoto = new System.Windows.Forms.PictureBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            labelFriendBirthday = new System.Windows.Forms.Label();
            labelFriendEmail = new System.Windows.Forms.Label();
            labelFriendMiddleName = new System.Windows.Forms.Label();
            labelFriendName = new System.Windows.Forms.Label();
            LabelFriendReligion = new System.Windows.Forms.Label();
            labelFriendUsername = new System.Windows.Forms.Label();
            labelGroupDescription = new System.Windows.Forms.Label();
            labelGroupName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).BeginInit();
            this.tabGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.tabFriends.SuspendLayout();
            this.panelFriendDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsDetailsBindingSource)).BeginInit();
            this.tabPhotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNormalURLPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            this.tabPosts.SuspendLayout();
            this.panelCreatePost.SuspendLayout();
            this.panelPost.SuspendLayout();
            this.panelPostBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhoto)).BeginInit();
            this.tabAbout.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAboutPhoto)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFriendBirthday
            // 
            labelFriendBirthday.AutoSize = true;
            labelFriendBirthday.Location = new System.Drawing.Point(14, 41);
            labelFriendBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelFriendBirthday.Name = "labelFriendBirthday";
            labelFriendBirthday.Size = new System.Drawing.Size(48, 13);
            labelFriendBirthday.TabIndex = 7;
            labelFriendBirthday.Text = "Birthday:";
            // 
            // labelFriendEmail
            // 
            labelFriendEmail.AutoSize = true;
            labelFriendEmail.Location = new System.Drawing.Point(14, 60);
            labelFriendEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelFriendEmail.Name = "labelFriendEmail";
            labelFriendEmail.Size = new System.Drawing.Size(35, 13);
            labelFriendEmail.TabIndex = 9;
            labelFriendEmail.Text = "Email:";
            // 
            // labelFriendMiddleName
            // 
            labelFriendMiddleName.AutoSize = true;
            labelFriendMiddleName.Location = new System.Drawing.Point(14, 79);
            labelFriendMiddleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelFriendMiddleName.Name = "labelFriendMiddleName";
            labelFriendMiddleName.Size = new System.Drawing.Size(72, 13);
            labelFriendMiddleName.TabIndex = 11;
            labelFriendMiddleName.Text = "Middle Name:";
            // 
            // labelFriendName
            // 
            labelFriendName.AutoSize = true;
            labelFriendName.Location = new System.Drawing.Point(14, 98);
            labelFriendName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelFriendName.Name = "labelFriendName";
            labelFriendName.Size = new System.Drawing.Size(38, 13);
            labelFriendName.TabIndex = 13;
            labelFriendName.Text = "Name:";
            // 
            // LabelFriendReligion
            // 
            LabelFriendReligion.AutoSize = true;
            LabelFriendReligion.Location = new System.Drawing.Point(14, 116);
            LabelFriendReligion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LabelFriendReligion.Name = "LabelFriendReligion";
            LabelFriendReligion.Size = new System.Drawing.Size(48, 13);
            LabelFriendReligion.TabIndex = 15;
            LabelFriendReligion.Text = "Religion:";
            // 
            // labelFriendUsername
            // 
            labelFriendUsername.AutoSize = true;
            labelFriendUsername.Location = new System.Drawing.Point(14, 135);
            labelFriendUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelFriendUsername.Name = "labelFriendUsername";
            labelFriendUsername.Size = new System.Drawing.Size(63, 13);
            labelFriendUsername.TabIndex = 17;
            labelFriendUsername.Text = "User Name:";
            // 
            // labelGroupDescription
            // 
            labelGroupDescription.AutoSize = true;
            labelGroupDescription.Location = new System.Drawing.Point(299, 89);
            labelGroupDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelGroupDescription.Name = "labelGroupDescription";
            labelGroupDescription.Size = new System.Drawing.Size(63, 13);
            labelGroupDescription.TabIndex = 6;
            labelGroupDescription.Text = "Description:";
            // 
            // labelGroupName
            // 
            labelGroupName.AutoSize = true;
            labelGroupName.Location = new System.Drawing.Point(299, 107);
            labelGroupName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelGroupName.Name = "labelGroupName";
            labelGroupName.Size = new System.Drawing.Size(38, 13);
            labelGroupName.TabIndex = 8;
            labelGroupName.Text = "Name:";
            // 
            // pictureBoxProfilePhoto
            // 
            this.pictureBoxProfilePhoto.Location = new System.Drawing.Point(604, 110);
            this.pictureBoxProfilePhoto.Name = "pictureBoxProfilePhoto";
            this.pictureBoxProfilePhoto.Size = new System.Drawing.Size(178, 214);
            this.pictureBoxProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePhoto.TabIndex = 3;
            this.pictureBoxProfilePhoto.TabStop = false;
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Location = new System.Drawing.Point(635, 47);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(0, 13);
            this.labelProfileName.TabIndex = 4;
            // 
            // tabGroups
            // 
            this.tabGroups.AutoScroll = true;
            this.tabGroups.Controls.Add(labelGroupDescription);
            this.tabGroups.Controls.Add(this.labelGroupDescriptionVal);
            this.tabGroups.Controls.Add(labelGroupName);
            this.tabGroups.Controls.Add(this.labelGroupNameVal);
            this.tabGroups.Controls.Add(this.listBoxGroups);
            this.tabGroups.Controls.Add(this.labelListOfGroups);
            this.tabGroups.Location = new System.Drawing.Point(4, 22);
            this.tabGroups.Margin = new System.Windows.Forms.Padding(2);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.Size = new System.Drawing.Size(552, 405);
            this.tabGroups.TabIndex = 5;
            this.tabGroups.Text = "Groups";
            this.tabGroups.UseVisualStyleBackColor = true;
            // 
            // labelGroupDescriptionVal
            // 
            this.labelGroupDescriptionVal.Location = new System.Drawing.Point(366, 89);
            this.labelGroupDescriptionVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGroupDescriptionVal.Name = "labelGroupDescriptionVal";
            this.labelGroupDescriptionVal.Size = new System.Drawing.Size(75, 19);
            this.labelGroupDescriptionVal.TabIndex = 7;
            // 
            // labelGroupNameVal
            // 
            this.labelGroupNameVal.Location = new System.Drawing.Point(366, 107);
            this.labelGroupNameVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGroupNameVal.Name = "labelGroupNameVal";
            this.labelGroupNameVal.Size = new System.Drawing.Size(75, 19);
            this.labelGroupNameVal.TabIndex = 9;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.DisplayMember = "Name";
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(16, 41);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(226, 173);
            this.listBoxGroups.TabIndex = 6;
            this.listBoxGroups.ValueMember = "Description";
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // labelListOfGroups
            // 
            this.labelListOfGroups.AutoSize = true;
            this.labelListOfGroups.Location = new System.Drawing.Point(26, 18);
            this.labelListOfGroups.Name = "labelListOfGroups";
            this.labelListOfGroups.Size = new System.Drawing.Size(75, 13);
            this.labelListOfGroups.TabIndex = 6;
            this.labelListOfGroups.Text = "List of Groups:";
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // tabFriends
            // 
            this.tabFriends.AutoScroll = true;
            this.tabFriends.Controls.Add(this.listBoxFriends);
            this.tabFriends.Controls.Add(this.labelListOfFriends);
            this.tabFriends.Controls.Add(this.panelFriendDetails);
            this.tabFriends.Location = new System.Drawing.Point(4, 22);
            this.tabFriends.Margin = new System.Windows.Forms.Padding(2);
            this.tabFriends.Name = "tabFriends";
            this.tabFriends.Padding = new System.Windows.Forms.Padding(2);
            this.tabFriends.Size = new System.Drawing.Size(552, 405);
            this.tabFriends.TabIndex = 2;
            this.tabFriends.Text = "Friends";
            this.tabFriends.UseVisualStyleBackColor = true;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DisplayMember = "About";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(26, 41);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(226, 342);
            this.listBoxFriends.TabIndex = 7;
            this.listBoxFriends.ValueMember = "About";
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // labelListOfFriends
            // 
            this.labelListOfFriends.AutoSize = true;
            this.labelListOfFriends.Location = new System.Drawing.Point(23, 17);
            this.labelListOfFriends.Name = "labelListOfFriends";
            this.labelListOfFriends.Size = new System.Drawing.Size(72, 13);
            this.labelListOfFriends.TabIndex = 7;
            this.labelListOfFriends.Text = "List of friends:";
            // 
            // panelFriendDetails
            // 
            this.panelFriendDetails.Controls.Add(labelFriendBirthday);
            this.panelFriendDetails.Controls.Add(this.labelFriendBirthdayVal);
            this.panelFriendDetails.Controls.Add(this.labelFriendUsernameVal);
            this.panelFriendDetails.Controls.Add(labelFriendEmail);
            this.panelFriendDetails.Controls.Add(labelFriendUsername);
            this.panelFriendDetails.Controls.Add(this.labelFriendReligionVal);
            this.panelFriendDetails.Controls.Add(this.labelFriendEmailVal);
            this.panelFriendDetails.Controls.Add(LabelFriendReligion);
            this.panelFriendDetails.Controls.Add(this.labelFriendNameVal);
            this.panelFriendDetails.Controls.Add(labelFriendMiddleName);
            this.panelFriendDetails.Controls.Add(labelFriendName);
            this.panelFriendDetails.Controls.Add(this.labelFriendMiddleNameVal);
            this.panelFriendDetails.Location = new System.Drawing.Point(318, 131);
            this.panelFriendDetails.Name = "panelFriendDetails";
            this.panelFriendDetails.Size = new System.Drawing.Size(172, 201);
            this.panelFriendDetails.TabIndex = 2;
            // 
            // labelFriendBirthdayVal
            // 
            this.labelFriendBirthdayVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendsDetailsBindingSource, "Birthday", true));
            this.labelFriendBirthdayVal.Location = new System.Drawing.Point(89, 41);
            this.labelFriendBirthdayVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendBirthdayVal.Name = "labelFriendBirthdayVal";
            this.labelFriendBirthdayVal.Size = new System.Drawing.Size(75, 19);
            this.labelFriendBirthdayVal.TabIndex = 8;
            // 
            // friendsDetailsBindingSource
            // 
            this.friendsDetailsBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // labelFriendUsernameVal
            // 
            this.labelFriendUsernameVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendsDetailsBindingSource, "UserName", true));
            this.labelFriendUsernameVal.Location = new System.Drawing.Point(89, 135);
            this.labelFriendUsernameVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendUsernameVal.Name = "labelFriendUsernameVal";
            this.labelFriendUsernameVal.Size = new System.Drawing.Size(75, 19);
            this.labelFriendUsernameVal.TabIndex = 18;
            // 
            // labelFriendReligionVal
            // 
            this.labelFriendReligionVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendsDetailsBindingSource, "Religion", true));
            this.labelFriendReligionVal.Location = new System.Drawing.Point(89, 116);
            this.labelFriendReligionVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendReligionVal.Name = "labelFriendReligionVal";
            this.labelFriendReligionVal.Size = new System.Drawing.Size(75, 19);
            this.labelFriendReligionVal.TabIndex = 16;
            // 
            // labelFriendEmailVal
            // 
            this.labelFriendEmailVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendsDetailsBindingSource, "Email", true));
            this.labelFriendEmailVal.Location = new System.Drawing.Point(89, 60);
            this.labelFriendEmailVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendEmailVal.Name = "labelFriendEmailVal";
            this.labelFriendEmailVal.Size = new System.Drawing.Size(75, 19);
            this.labelFriendEmailVal.TabIndex = 10;
            // 
            // labelFriendNameVal
            // 
            this.labelFriendNameVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendsDetailsBindingSource, "Name", true));
            this.labelFriendNameVal.Location = new System.Drawing.Point(89, 98);
            this.labelFriendNameVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendNameVal.Name = "labelFriendNameVal";
            this.labelFriendNameVal.Size = new System.Drawing.Size(75, 19);
            this.labelFriendNameVal.TabIndex = 14;
            // 
            // labelFriendMiddleNameVal
            // 
            this.labelFriendMiddleNameVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendsDetailsBindingSource, "MiddleName", true));
            this.labelFriendMiddleNameVal.Location = new System.Drawing.Point(89, 79);
            this.labelFriendMiddleNameVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendMiddleNameVal.Name = "labelFriendMiddleNameVal";
            this.labelFriendMiddleNameVal.Size = new System.Drawing.Size(75, 19);
            this.labelFriendMiddleNameVal.TabIndex = 12;
            // 
            // tabPhotos
            // 
            this.tabPhotos.AutoScroll = true;
            this.tabPhotos.Controls.Add(this.pictureNormalURLPictureBox);
            this.tabPhotos.Controls.Add(this.listBoxPhotos);
            this.tabPhotos.Controls.Add(this.listBoxAlbums);
            this.tabPhotos.Controls.Add(this.label3);
            this.tabPhotos.Controls.Add(this.label2);
            this.tabPhotos.Location = new System.Drawing.Point(4, 22);
            this.tabPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.tabPhotos.Name = "tabPhotos";
            this.tabPhotos.Padding = new System.Windows.Forms.Padding(2);
            this.tabPhotos.Size = new System.Drawing.Size(552, 405);
            this.tabPhotos.TabIndex = 1;
            this.tabPhotos.Text = "Photos";
            this.tabPhotos.UseVisualStyleBackColor = true;
            // 
            // pictureNormalURLPictureBox
            // 
            this.pictureNormalURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photoBindingSource, "PictureNormalURL", true));
            this.pictureNormalURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.photoBindingSource, "PictureNormalURL", true));
            this.pictureNormalURLPictureBox.Location = new System.Drawing.Point(176, 56);
            this.pictureNormalURLPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureNormalURLPictureBox.Name = "pictureNormalURLPictureBox";
            this.pictureNormalURLPictureBox.Size = new System.Drawing.Size(250, 263);
            this.pictureNormalURLPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNormalURLPictureBox.TabIndex = 8;
            this.pictureNormalURLPictureBox.TabStop = false;
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
            // 
            // listBoxPhotos
            // 
            this.listBoxPhotos.DisplayMember = "Album";
            this.listBoxPhotos.FormattingEnabled = true;
            this.listBoxPhotos.Location = new System.Drawing.Point(27, 199);
            this.listBoxPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPhotos.Name = "listBoxPhotos";
            this.listBoxPhotos.Size = new System.Drawing.Size(81, 121);
            this.listBoxPhotos.TabIndex = 7;
            this.listBoxPhotos.ValueMember = "Album";
            this.listBoxPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotos_SelectedIndexChanged);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.DisplayMember = "Comments";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(25, 56);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(84, 108);
            this.listBoxAlbums.TabIndex = 7;
            this.listBoxAlbums.ValueMember = "Comments";
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose Photo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Album:";
            // 
            // tabPosts
            // 
            this.tabPosts.Controls.Add(this.label1);
            this.tabPosts.Controls.Add(this.buttonBestHourToPostByComments);
            this.tabPosts.Controls.Add(this.labelBestHourToPostVal);
            this.tabPosts.Controls.Add(this.buttonBestHourToPostByLikes);
            this.tabPosts.Controls.Add(this.panelCreatePost);
            this.tabPosts.Controls.Add(this.comboBoxPostsFilter);
            this.tabPosts.Controls.Add(this.labelPostsFilter);
            this.tabPosts.Controls.Add(this.labelPostsSubFilter);
            this.tabPosts.Controls.Add(this.listBoxPosts);
            this.tabPosts.Controls.Add(this.comboBoxPostsSubFilter);
            this.tabPosts.Controls.Add(this.panelPost);
            this.tabPosts.Location = new System.Drawing.Point(4, 22);
            this.tabPosts.Margin = new System.Windows.Forms.Padding(2);
            this.tabPosts.Name = "tabPosts";
            this.tabPosts.Padding = new System.Windows.Forms.Padding(2);
            this.tabPosts.Size = new System.Drawing.Size(552, 405);
            this.tabPosts.TabIndex = 0;
            this.tabPosts.Text = "Posts";
            this.tabPosts.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Best Hour To Post:";
            // 
            // buttonBestHourToPostByComments
            // 
            this.buttonBestHourToPostByComments.Location = new System.Drawing.Point(16, 243);
            this.buttonBestHourToPostByComments.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBestHourToPostByComments.Name = "buttonBestHourToPostByComments";
            this.buttonBestHourToPostByComments.Size = new System.Drawing.Size(199, 21);
            this.buttonBestHourToPostByComments.TabIndex = 19;
            this.buttonBestHourToPostByComments.Text = "Get Best Hour To Post By Comments";
            this.buttonBestHourToPostByComments.UseVisualStyleBackColor = true;
            this.buttonBestHourToPostByComments.Click += new System.EventHandler(this.buttonBestHourToPostByComments_Click);
            // 
            // labelBestHourToPostVal
            // 
            this.labelBestHourToPostVal.AutoSize = true;
            this.labelBestHourToPostVal.Location = new System.Drawing.Point(135, 271);
            this.labelBestHourToPostVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBestHourToPostVal.Name = "labelBestHourToPostVal";
            this.labelBestHourToPostVal.Size = new System.Drawing.Size(0, 13);
            this.labelBestHourToPostVal.TabIndex = 18;
            // 
            // buttonBestHourToPostByLikes
            // 
            this.buttonBestHourToPostByLikes.Location = new System.Drawing.Point(16, 218);
            this.buttonBestHourToPostByLikes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBestHourToPostByLikes.Name = "buttonBestHourToPostByLikes";
            this.buttonBestHourToPostByLikes.Size = new System.Drawing.Size(199, 21);
            this.buttonBestHourToPostByLikes.TabIndex = 17;
            this.buttonBestHourToPostByLikes.Text = "Get Best Hour To Post By Likes";
            this.buttonBestHourToPostByLikes.UseVisualStyleBackColor = true;
            this.buttonBestHourToPostByLikes.Click += new System.EventHandler(this.buttonBestHourToPostByLikes_Click);
            // 
            // panelCreatePost
            // 
            this.panelCreatePost.Controls.Add(this.richTextBoxCreatePost);
            this.panelCreatePost.Controls.Add(this.buttonCreatePost);
            this.panelCreatePost.Controls.Add(this.labelCreatePost);
            this.panelCreatePost.Location = new System.Drawing.Point(16, 293);
            this.panelCreatePost.Name = "panelCreatePost";
            this.panelCreatePost.Size = new System.Drawing.Size(174, 106);
            this.panelCreatePost.TabIndex = 16;
            // 
            // richTextBoxCreatePost
            // 
            this.richTextBoxCreatePost.Location = new System.Drawing.Point(17, 32);
            this.richTextBoxCreatePost.Name = "richTextBoxCreatePost";
            this.richTextBoxCreatePost.Size = new System.Drawing.Size(146, 42);
            this.richTextBoxCreatePost.TabIndex = 16;
            this.richTextBoxCreatePost.Text = "";
            // 
            // buttonCreatePost
            // 
            this.buttonCreatePost.Location = new System.Drawing.Point(44, 80);
            this.buttonCreatePost.Name = "buttonCreatePost";
            this.buttonCreatePost.Size = new System.Drawing.Size(75, 23);
            this.buttonCreatePost.TabIndex = 15;
            this.buttonCreatePost.Text = "Post";
            this.buttonCreatePost.UseVisualStyleBackColor = true;
            this.buttonCreatePost.Click += new System.EventHandler(this.buttonCreatePost_Click);
            // 
            // labelCreatePost
            // 
            this.labelCreatePost.AutoSize = true;
            this.labelCreatePost.Location = new System.Drawing.Point(46, 15);
            this.labelCreatePost.Name = "labelCreatePost";
            this.labelCreatePost.Size = new System.Drawing.Size(73, 13);
            this.labelCreatePost.TabIndex = 13;
            this.labelCreatePost.Text = "Create a post:";
            // 
            // comboBoxPostsFilter
            // 
            this.comboBoxPostsFilter.FormattingEnabled = true;
            this.comboBoxPostsFilter.Location = new System.Drawing.Point(16, 45);
            this.comboBoxPostsFilter.Name = "comboBoxPostsFilter";
            this.comboBoxPostsFilter.Size = new System.Drawing.Size(139, 21);
            this.comboBoxPostsFilter.TabIndex = 12;
            this.comboBoxPostsFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxPostsFilter_SelectedIndexChanged);
            // 
            // labelPostsFilter
            // 
            this.labelPostsFilter.AutoSize = true;
            this.labelPostsFilter.Location = new System.Drawing.Point(14, 21);
            this.labelPostsFilter.Name = "labelPostsFilter";
            this.labelPostsFilter.Size = new System.Drawing.Size(149, 13);
            this.labelPostsFilter.TabIndex = 11;
            this.labelPostsFilter.Text = "Choose category to filter posts";
            // 
            // labelPostsSubFilter
            // 
            this.labelPostsSubFilter.AutoSize = true;
            this.labelPostsSubFilter.Location = new System.Drawing.Point(14, 77);
            this.labelPostsSubFilter.Name = "labelPostsSubFilter";
            this.labelPostsSubFilter.Size = new System.Drawing.Size(105, 13);
            this.labelPostsSubFilter.TabIndex = 5;
            this.labelPostsSubFilter.Text = "Filter posts by places";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DisplayMember = "Caption";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(16, 143);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(174, 56);
            this.listBoxPosts.TabIndex = 1;
            this.listBoxPosts.ValueMember = "Caption";
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // comboBoxPostsSubFilter
            // 
            this.comboBoxPostsSubFilter.FormattingEnabled = true;
            this.comboBoxPostsSubFilter.Location = new System.Drawing.Point(16, 103);
            this.comboBoxPostsSubFilter.Name = "comboBoxPostsSubFilter";
            this.comboBoxPostsSubFilter.Size = new System.Drawing.Size(139, 21);
            this.comboBoxPostsSubFilter.TabIndex = 2;
            this.comboBoxPostsSubFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxPostsSubFilter_SelectedIndexChanged);
            // 
            // panelPost
            // 
            this.panelPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPost.Controls.Add(this.panelPostBody);
            this.panelPost.Controls.Add(this.labelPostName);
            this.panelPost.Controls.Add(this.pictureBoxPostPhoto);
            this.panelPost.Location = new System.Drawing.Point(234, 21);
            this.panelPost.Name = "panelPost";
            this.panelPost.Size = new System.Drawing.Size(290, 365);
            this.panelPost.TabIndex = 10;
            // 
            // panelPostBody
            // 
            this.panelPostBody.AutoScroll = true;
            this.panelPostBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPostBody.Controls.Add(this.labelPostBody);
            this.panelPostBody.Location = new System.Drawing.Point(17, 55);
            this.panelPostBody.Name = "panelPostBody";
            this.panelPostBody.Size = new System.Drawing.Size(238, 176);
            this.panelPostBody.TabIndex = 8;
            // 
            // labelPostBody
            // 
            this.labelPostBody.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.labelPostBody.Location = new System.Drawing.Point(14, 16);
            this.labelPostBody.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPostBody.Name = "labelPostBody";
            this.labelPostBody.Size = new System.Drawing.Size(211, 145);
            this.labelPostBody.TabIndex = 1;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // labelPostName
            // 
            this.labelPostName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Name", true));
            this.labelPostName.Location = new System.Drawing.Point(32, 23);
            this.labelPostName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPostName.Name = "labelPostName";
            this.labelPostName.Size = new System.Drawing.Size(211, 19);
            this.labelPostName.TabIndex = 3;
            // 
            // pictureBoxPostPhoto
            // 
            this.pictureBoxPostPhoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.postBindingSource, "PictureURL", true));
            this.pictureBoxPostPhoto.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.postBindingSource, "PictureURL", true));
            this.pictureBoxPostPhoto.Location = new System.Drawing.Point(17, 240);
            this.pictureBoxPostPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPostPhoto.Name = "pictureBoxPostPhoto";
            this.pictureBoxPostPhoto.Size = new System.Drawing.Size(238, 105);
            this.pictureBoxPostPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPostPhoto.TabIndex = 5;
            this.pictureBoxPostPhoto.TabStop = false;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.panel10);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(552, 405);
            this.tabAbout.TabIndex = 7;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.labelAboutBirthYearVal);
            this.panel10.Controls.Add(this.labelAboutGenderVal);
            this.panel10.Controls.Add(this.labelAboutNameVal);
            this.panel10.Controls.Add(this.labelAboutGender);
            this.panel10.Controls.Add(this.labelAboutBirthYear);
            this.panel10.Controls.Add(this.labelAboutName);
            this.panel10.Controls.Add(this.pictureBoxAboutPhoto);
            this.panel10.Location = new System.Drawing.Point(75, 58);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(358, 283);
            this.panel10.TabIndex = 3;
            // 
            // labelAboutBirthYearVal
            // 
            this.labelAboutBirthYearVal.AutoSize = true;
            this.labelAboutBirthYearVal.Location = new System.Drawing.Point(165, 182);
            this.labelAboutBirthYearVal.Name = "labelAboutBirthYearVal";
            this.labelAboutBirthYearVal.Size = new System.Drawing.Size(35, 13);
            this.labelAboutBirthYearVal.TabIndex = 7;
            this.labelAboutBirthYearVal.Text = "empty";
            // 
            // labelAboutGenderVal
            // 
            this.labelAboutGenderVal.AutoSize = true;
            this.labelAboutGenderVal.Location = new System.Drawing.Point(159, 159);
            this.labelAboutGenderVal.Name = "labelAboutGenderVal";
            this.labelAboutGenderVal.Size = new System.Drawing.Size(35, 13);
            this.labelAboutGenderVal.TabIndex = 6;
            this.labelAboutGenderVal.Text = "empty";
            // 
            // labelAboutNameVal
            // 
            this.labelAboutNameVal.AutoSize = true;
            this.labelAboutNameVal.Location = new System.Drawing.Point(152, 16);
            this.labelAboutNameVal.Name = "labelAboutNameVal";
            this.labelAboutNameVal.Size = new System.Drawing.Size(35, 13);
            this.labelAboutNameVal.TabIndex = 5;
            this.labelAboutNameVal.Text = "empty";
            // 
            // labelAboutGender
            // 
            this.labelAboutGender.AutoSize = true;
            this.labelAboutGender.Location = new System.Drawing.Point(108, 159);
            this.labelAboutGender.Name = "labelAboutGender";
            this.labelAboutGender.Size = new System.Drawing.Size(45, 13);
            this.labelAboutGender.TabIndex = 4;
            this.labelAboutGender.Text = "Gender:";
            // 
            // labelAboutBirthYear
            // 
            this.labelAboutBirthYear.AutoSize = true;
            this.labelAboutBirthYear.Location = new System.Drawing.Point(105, 182);
            this.labelAboutBirthYear.Name = "labelAboutBirthYear";
            this.labelAboutBirthYear.Size = new System.Drawing.Size(54, 13);
            this.labelAboutBirthYear.TabIndex = 3;
            this.labelAboutBirthYear.Text = "Birth year:";
            // 
            // labelAboutName
            // 
            this.labelAboutName.AutoSize = true;
            this.labelAboutName.Location = new System.Drawing.Point(106, 16);
            this.labelAboutName.Name = "labelAboutName";
            this.labelAboutName.Size = new System.Drawing.Size(38, 13);
            this.labelAboutName.TabIndex = 1;
            this.labelAboutName.Text = "Name:";
            // 
            // pictureBoxAboutPhoto
            // 
            this.pictureBoxAboutPhoto.Location = new System.Drawing.Point(108, 42);
            this.pictureBoxAboutPhoto.Name = "pictureBoxAboutPhoto";
            this.pictureBoxAboutPhoto.Size = new System.Drawing.Size(110, 102);
            this.pictureBoxAboutPhoto.TabIndex = 0;
            this.pictureBoxAboutPhoto.TabStop = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabAbout);
            this.tabControl2.Controls.Add(this.tabPosts);
            this.tabControl2.Controls.Add(this.tabPhotos);
            this.tabControl2.Controls.Add(this.tabFriends);
            this.tabControl2.Controls.Add(this.tabGroups);
            this.tabControl2.Location = new System.Drawing.Point(22, 18);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(560, 431);
            this.tabControl2.TabIndex = 14;
            this.tabControl2.Tag = "fds";
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(638, 356);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(95, 17);
            this.checkBoxRememberMe.TabIndex = 15;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.pictureBoxProfilePhoto);
            this.Controls.Add(this.labelProfileName);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).EndInit();
            this.tabGroups.ResumeLayout(false);
            this.tabGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.tabFriends.ResumeLayout(false);
            this.tabFriends.PerformLayout();
            this.panelFriendDetails.ResumeLayout(false);
            this.panelFriendDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsDetailsBindingSource)).EndInit();
            this.tabPhotos.ResumeLayout(false);
            this.tabPhotos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNormalURLPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            this.tabPosts.ResumeLayout(false);
            this.tabPosts.PerformLayout();
            this.panelCreatePost.ResumeLayout(false);
            this.panelCreatePost.PerformLayout();
            this.panelPost.ResumeLayout(false);
            this.panelPostBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhoto)).EndInit();
            this.tabAbout.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAboutPhoto)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxProfilePhoto;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label labelAboutBirthYearVal;
        private System.Windows.Forms.Label labelAboutGenderVal;
        private System.Windows.Forms.Label labelAboutNameVal;
        private System.Windows.Forms.Label labelAboutGender;
        private System.Windows.Forms.Label labelAboutBirthYear;
        private System.Windows.Forms.Label labelAboutName;
        private System.Windows.Forms.PictureBox pictureBoxAboutPhoto;
        private System.Windows.Forms.TabPage tabPosts;
        private System.Windows.Forms.Panel panelCreatePost;
        private System.Windows.Forms.RichTextBox richTextBoxCreatePost;
        private System.Windows.Forms.Button buttonCreatePost;
        private System.Windows.Forms.Label labelCreatePost;
        private System.Windows.Forms.ComboBox comboBoxPostsFilter;
        private System.Windows.Forms.Label labelPostsFilter;
        private System.Windows.Forms.Label labelPostsSubFilter;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ComboBox comboBoxPostsSubFilter;
        private System.Windows.Forms.Panel panelPost;
        private System.Windows.Forms.Panel panelPostBody;
        private System.Windows.Forms.TabPage tabPhotos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabFriends;
        private System.Windows.Forms.Label labelListOfFriends;
        private System.Windows.Forms.Panel panelFriendDetails;
        private System.Windows.Forms.TabPage tabGroups;
        private System.Windows.Forms.Label labelListOfGroups;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxPhotos;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.BindingSource friendsDetailsBindingSource;
        private System.Windows.Forms.Label labelFriendBirthdayVal;
        private System.Windows.Forms.Label labelFriendUsernameVal;
        private System.Windows.Forms.Label labelFriendReligionVal;
        private System.Windows.Forms.Label labelFriendEmailVal;
        private System.Windows.Forms.Label labelFriendNameVal;
        private System.Windows.Forms.Label labelFriendMiddleNameVal;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.Label labelGroupDescriptionVal;
        private System.Windows.Forms.Label labelGroupNameVal;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Label labelPostBody;
        private System.Windows.Forms.Label labelPostName;
        private System.Windows.Forms.PictureBox pictureBoxPostPhoto;
        private System.Windows.Forms.Label labelBestHourToPostVal;
        private System.Windows.Forms.PictureBox pictureNormalURLPictureBox;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Button buttonBestHourToPostByComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBestHourToPostByLikes;
    }
}
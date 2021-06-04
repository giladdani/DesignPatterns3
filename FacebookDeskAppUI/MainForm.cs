using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookDeskAppLogic;

namespace FacebookDeskAppUI
{
    public partial class MainForm : Form
    {
        // Private Members
        private const string k_AllTitle = "All";
        private const string k_PlacesTitle = "Places";
        private const string k_CommentsTitle = "Comments";
        private const string k_LikesTitle = "Likes";
        private static readonly object Sr_lock = new object();
        private LoggedinUserData m_LoggedInUserData;

        // Ctor
        public MainForm()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        //------------------------  General Methods  ---------------------------//
        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        /*private void setListBox<T>(ICollection<T> i_List, ListBox i_ListBox)
        {
            lock(Sr_lock)
            {
                i_ListBox.Items.Clear();
                foreach(T elem in i_List)
                {
                    i_ListBox.Items.Add(elem);
                }
            }
        }*/

        private void setListBox<T>(IEnumerator<T> i_PostsIterator, ListBox i_ListBox)
        {
            lock (Sr_lock)
            {
                i_ListBox.Items.Clear();
                while(i_PostsIterator.MoveNext())
                {
                    i_ListBox.Items.Add(i_PostsIterator.Current);
                }
            }
        }

        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        //------------------- Setting ListBox of posts Methods------------------//
        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        private void setPostsListByPlaces(string i_PlaceName)
        {
            ICollection<Post> listOfPosts = m_LoggedInUserData.GetPostsByPlaceName(i_PlaceName);
            if(listOfPosts != null)
            {
                ICollection<PostWrapper> listOfPostsWrapper = generateListOfPostsWrappers(listOfPosts);
                setListBox(listOfPostsWrapper.GetEnumerator(), listBoxPosts);
            }
        }

       /* private void setListBoxPostsByComments(int i_NumOfComments)
        {
            
            IStrategy strategy = m_LoggedInUserData.CreateStrategyByCategory(i_NumOfComments);
            // ICollection<Post> listOfPosts = m_LoggedInUserData.GetPostsByNumOfComments(i_NumOfComments);
            m_LoggedInUserData.PostsCollection.GetEnumerator(PostsCollection.IteratorType.COMMENTS, strategy);
            if(listOfPosts != null)
            {
                ICollection<PostWrapper> listOfPostsWrapper = generateListOfPostsWrappers(listOfPosts);
                setListBox(listOfPostsWrapper.GetEnumerator(), listBoxPosts);
            }
        }*/

        private void setListBoxPosts(PostsCollection.IteratorType i_IteratorType, int i_Num)
        {

            IStrategy strategy = m_LoggedInUserData.CreateStrategyByCategory(i_Num);
            // ICollection<Post> listOfPosts = m_LoggedInUserData.GetPostsByNumOfComments(i_NumOfComments);
            IEnumerator<Post> postsIterator = m_LoggedInUserData.PostsCollection.GetEnumerator(i_IteratorType, strategy);
            setListBox(postsIterator, listBoxPosts);
        }

       /* private void setListBoxPostsByLikes(int i_NumOfLikes)
        {
            ICollection<Post> listOfPosts = m_LoggedInUserData.GetPostsByNumOfLikes(i_NumOfLikes);
            if(listOfPosts != null)
            {
                ICollection<PostWrapper> listOfPostsWrapper = generateListOfPostsWrappers(listOfPosts);
                setListBox(listOfPostsWrapper, listBoxPosts);
            }
        }*/

        private void setListBoxPostsByListOfAll()
        {
            listBoxPosts.Items.Clear();
            IEnumerator<Post> postsIterator = m_LoggedInUserData.PostsCollection.GetEnumerator();
            setListBox(postsIterator, listBoxPosts);
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PostWrapper postWrapper = listBoxPosts.SelectedItem as PostWrapper;
                postBindingSource.DataSource = postWrapper.Post;
            }
            catch(Exception)
            {
                MessageBox.Show("Failed to show post");
            }
        }

        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        //----------- Setting combobox of sub filter of posts Methods-----------//
        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        private void setComboboxPostsSubFilter(ICollection<string> i_Options)
        {
            foreach(string option in i_Options)
            {
                comboBoxPostsSubFilter.Items.Add(option);
            }
        }

        private void setComboboxPostsSubFilterByPlaces()
        {
            labelPostsSubFilter.Text = "Filter by places";
            m_LoggedInUserData.FetchPostsByPlaces();
            List<string> listOfPlacesNames = m_LoggedInUserData.GetPlaceNamesOfPosts();
            setComboboxPostsSubFilter(listOfPlacesNames);
        }

        private void setComboboxPostsSubFilterByLikes()
        {
            try
            {
              //  m_LoggedInUserData.FetchPostsByNumOfLikes();
                labelPostsSubFilter.Text = "Filter by likes";
                setComboboxPostsSubFilterByNumericOptions();
            }
            catch(Exception)
            {
                MessageBox.Show("Could not fetch posts :(");
            }
        }

        private void setComboboxPostsSubFilterByComments()
        {
            labelPostsSubFilter.Text = "Filter by comments";
            //m_LoggedInUserData.FetchPostsByNumOfComments();
            setComboboxPostsSubFilterByNumericOptions();
        }

        private void setComboboxPostsSubFilterByNumericOptions()
        {
            List<string> listOfNumOfOptions = new List<string>();
            listOfNumOfOptions.Add("0-9");
            listOfNumOfOptions.Add("11-99");
            listOfNumOfOptions.Add("100 And Above");
            setComboboxPostsSubFilter(listOfNumOfOptions);
        }

        private int getNumericValueOfSubFilter(string optionStr)
        {
            int num  = -1;
            if(optionStr.Equals("0-9"))
            {
                num = 0;
            }
            else if(optionStr.Equals("11-99"))
            {
                num = 11;
            }
            else if(optionStr.Equals("100 And Above"))
            {
                num = 100;
            }
            return num;
        }

        private void comboBoxPostsSubFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string optionOfFilter = comboBoxPostsFilter.Text;
            string optionOfSubFilter = comboBoxPostsSubFilter.Text;
            int optionOfSubFilterNum = getNumericValueOfSubFilter(optionOfSubFilter);
            listBoxPosts.Items.Clear();

            if(optionOfFilter == k_PlacesTitle)
            {
                setPostsListByPlaces(optionOfSubFilter);
            }
            else if(optionOfFilter == k_LikesTitle)
            {
                
                setListBoxPosts(PostsCollection.IteratorType.LIKES, optionOfSubFilterNum);
            }
            else if(optionOfFilter == k_CommentsTitle)
            {
                setListBoxPosts(PostsCollection.IteratorType.COMMENTS, optionOfSubFilterNum);
            }
        }

        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        //-----------------combobox of filter of posts Methods------------------//
        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        private void setComboBoxPostsFilter()
        {
            comboBoxPostsSubFilter.Visible = false;
            labelPostsSubFilter.Visible = false;
            comboBoxPostsFilter.Items.Clear();
            comboBoxPostsFilter.Items.Add(k_AllTitle);
            comboBoxPostsFilter.Items.Add(k_PlacesTitle);
            comboBoxPostsFilter.Items.Add(k_LikesTitle);
            comboBoxPostsFilter.Items.Add(k_CommentsTitle);
        }

        private void comboBoxPostsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = comboBoxPostsFilter.Text;
            if(category == k_AllTitle)
            {
                comboBoxPostsSubFilter.Visible = false;
                labelPostsSubFilter.Visible = false;
                setListBoxPostsByListOfAll();
            }
            else if(category == k_PlacesTitle)
            {
                setGeneralOptionsToSubFilterComponents();
                setComboboxPostsSubFilterByPlaces();
            }
            else if(category == k_LikesTitle)
            {
                setGeneralOptionsToSubFilterComponents();
                setComboboxPostsSubFilterByLikes();
            }
            else if(category == k_CommentsTitle)
            {
                setGeneralOptionsToSubFilterComponents();
                setComboboxPostsSubFilterByComments();
            }
        }

        private void setGeneralOptionsToSubFilterComponents()
        {
            comboBoxPostsSubFilter.Visible = true;
            labelPostsSubFilter.Visible = true;
            comboBoxPostsSubFilter.Items.Clear();
        }

        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        //---------------------------login Methods------------------------------//
        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxAlbums.SelectedItem != null)
            {
                try
                {
                    listBoxPhotos.Items.Clear();
                    string albumName = (listBoxAlbums.SelectedItem as Album).Name;
                    List<Photo> photos = m_LoggedInUserData.FetchPhotosByAlbumName(albumName);
                    setListBox(photos.GetEnumerator(), listBoxPhotos);
                }
                catch(Exception)
                {
                    MessageBox.Show("Error fetching photos from album");
                }
            }
        }

        private void listBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxPhotos.SelectedItem is Photo photo)
            {
                photoBindingSource.DataSource = photo;
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            friendsDetailsBindingSource.DataSource = listBoxFriends.SelectedItem as User;
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBindingSource.DataSource = listBoxGroups.SelectedItem as Group;
        }

        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        //---------------------------Wrapper Methods----------------------------//
        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        private ICollection<PostWrapper> generateListOfPostsWrappers(ICollection<Post> i_ListOfPosts)
        {
            ICollection<PostWrapper> listOfPostWrapper = new List<PostWrapper>();
            foreach(Post post in i_ListOfPosts)
            {
                PostWrapper postWrapper = new PostWrapper(post);
                listOfPostWrapper.Add(postWrapper);
            }

            return listOfPostWrapper;
        }

        private void buttonBestHourToPost_Click(object sender, EventArgs e)
        {
            try
            {
                int bestHourToPost = m_LoggedInUserData.GetBestTimeForStatus();
                labelBestHourToPostVal.Text = $"Best hour to post: {bestHourToPost}:00";
            }
            catch(Exception)
            {
                MessageBox.Show("Could not calculate Best time :(");
            }
        }

        private void buttonCreatePost_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = m_LoggedInUserData.User.PostStatus(richTextBoxCreatePost.Text);
                MessageBox.Show("Post was published successfully!");
            }
            catch(Exception)
            {
                MessageBox.Show("Could not publish post :(");
            }
        }

        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        //----------------------initialization Methods--------------------------//
        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        public void InitFormDetails()
        {
            m_LoggedInUserData = Singleton<LoggedinUserData>.Instance;
            setProfileDetails();
            setAboutPage();
            new Thread(setPostsPage).Start();
            new Thread(setAlbumsPage).Start();
            new Thread(setFriendsPage).Start();
            new Thread(setGroupsPage).Start();
        }

        private void setProfileDetails()
        {
            labelProfileName.Text = "Welcome, " + m_LoggedInUserData.User.Name;
            pictureBoxProfilePhoto.ImageLocation = m_LoggedInUserData.User.PictureNormalURL;
        }

        private void setAboutPage()
        {
            labelAboutNameVal.Text = m_LoggedInUserData.User.Name;
            pictureBoxAboutPhoto.ImageLocation = m_LoggedInUserData.User.PictureNormalURL;
            labelAboutGenderVal.Text = m_LoggedInUserData.User.Gender.ToString();
            labelAboutBirthYearVal.Text = m_LoggedInUserData.User.Birthday;
        }

        private void setPostsPage()
        {
            setComboBoxPostsFilter();
        }

        private void setAlbumsPage()
        {
            try
            {
                listBoxAlbums.DisplayMember = "Name";
                listBoxPhotos.DisplayMember = "Id";
                m_LoggedInUserData.FetchAlbums();
                ICollection<Album> albums = m_LoggedInUserData.GetAllAlbums();
                setListBox(albums.GetEnumerator(), listBoxAlbums);
            }
            catch(Exception)
            {
                MessageBox.Show("Error in fetching albums");
            }
        }

        private void setFriendsPage()
        {
            try
            {
                listBoxFriends.DisplayMember = "Name";
                m_LoggedInUserData.FetchFriends();
                ICollection<User> friends = m_LoggedInUserData.GetAllFriends();
                setListBox(friends.GetEnumerator(), listBoxFriends);
            }
            catch(Exception)
            {
                MessageBox.Show("Error in fetching friends");
            }
        }

        private void setGroupsPage()
        {
            try
            {
                listBoxGroups.DisplayMember = "Name";
                m_LoggedInUserData.FetchGroups();
                ICollection<Group> groups = m_LoggedInUserData.GetAllGroups();
                setListBox(groups.GetEnumerator(), listBoxGroups);
            }
            catch(Exception)
            {
                MessageBox.Show("Problem in fetching groups");
            }
        }

        public bool IsRememberSettingsChecked()
        {
            bool isChecked = checkBoxRememberMe.Checked;
            return isChecked;
        }
    }
}
using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookDeskAppLogic
{
    public sealed class LoggedinUserData
    {
        private ICollection<Album> m_ListOfAlbums = new List<Album>();
        private ICollection<User> m_ListOfFriends = new List<User>();
        private ICollection<Group> m_ListOfGroups = new List<Group>();

        // Constructor
        private LoggedinUserData()
        {
        }
 
        // Public Methods
        public void FetchPosts()
        {
            PostsCollection = new PostsCollection(User);
        }

        public void FetchFriends()
        {
            foreach (User friend in User.Friends)
            {
                m_ListOfFriends.Add(friend);
            }
        }

        public void FetchGroups()
        {
            foreach (Group group in User.Groups)
            {
                m_ListOfGroups.Add(group);
            }
        }

        public void FetchAlbums()
        {
            foreach (Album album in User.Albums)
            {
                m_ListOfAlbums.Add(album);
            }
        }

        public List<Photo> FetchPhotosByAlbumName(string i_AlbumName)
        {
            List<Photo> listOfPhotos = new List<Photo>();
            try
            {
                foreach (Album album in User.Albums)
                {
                    if (album.Name == i_AlbumName)
                    {
                        foreach (Photo photo in album.Photos)
                        {
                            listOfPhotos.Add(photo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listOfPhotos;
        }

        public ICollection<Album> GetAllAlbums()
        {
            return m_ListOfAlbums;
        }

        public ICollection<User> GetAllFriends()
        {
            return m_ListOfFriends;
        }

        public ICollection<Group> GetAllGroups()
        {
            return m_ListOfGroups;
        }

        public IStrategy CreateStrategyByCategory(int i_NumCategory)
        {
            IStrategy strategy;

            if (i_NumCategory < 10 && i_NumCategory >= 0)
            {
                strategy = new OneDigitStrategy();
            }
            else if (i_NumCategory < 100 && i_NumCategory >= 10)
            {
                strategy = new TwoDigitsStrategy();
            }
            else
            {
                strategy = new AboveTwoDigitsStrategy();
            }

            return strategy;
        }

        public int GetBestTimeForStatus(GetBestTimeForStatusBase i_GetBestTimeForStatus)
        {
            return i_GetBestTimeForStatus.GetBestTimeForStatus(PostsCollection);
        }

        // Properties
        public LoginResult LoginResult { get; set; }

        public PostsCollection PostsCollection { get; set; }

        public User User { get; set; }

        public GetBestTimeForStatusByComments GetBestTimeForStatusByComments { get; } = new GetBestTimeForStatusByComments();

        public GetBestTimeForStatusByLikes GetBestTimeForStatusByLikes { get; } = new GetBestTimeForStatusByLikes();
    }
}
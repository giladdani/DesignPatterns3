using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookDeskAppLogic
{
    public sealed class LoggedinUserData
    {
        // Private Members
        private User m_User;
        private LoginResult m_LoginResult;
        private PostsCollection m_PostsCollection = null;
        private IDictionary<string, List<Post>> m_DictionaryOfPostsByPlaces = new Dictionary<string, List<Post>>();
        private ICollection<Album> m_ListOfAlbums = new List<Album>();
        private ICollection<User> m_ListOfFriends = new List<User>();
        private ICollection<Group> m_ListOfGroups = new List<Group>();
        private readonly GetBestTimeForStatusByComments m_GetBestTimeForStatusByComments = new GetBestTimeForStatusByComments();
        private readonly GetBestTimeForStatusByLikes m_GetBestTimeForStatusByLikes = new GetBestTimeForStatusByLikes();

        // Constructors
        private LoggedinUserData()
        {
        }

        public GetBestTimeForStatusByLikes GetBestTimeForStatusByLikes
        {
            get
            {
                return m_GetBestTimeForStatusByLikes;
            }
        }

        public GetBestTimeForStatusByComments GetBestTimeForStatusByComments
        {
            get
            {
                return m_GetBestTimeForStatusByComments;
            }
        }


        // Properties
        public LoginResult LoginResult
        {
            get
            {
                return m_LoginResult;
            }

            set
            {
                m_LoginResult = value;
            }
        }

        public PostsCollection PostsCollection
        {
            get
            {
                return m_PostsCollection;
            }

            set
            {
                m_PostsCollection = value;
            }
        }

        public User User
        {
            get
            {
                return m_User;
            }

            set
            {
                m_User = value;
            }
        }

        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        //---------------------------Dictionary methods-------------------------//
        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        private void addElementToDictionaryByKey<T>(string i_Key, IDictionary<string, List<T>> i_Dictionary, T i_Element)
        {
            if (i_Dictionary.ContainsKey(i_Key))
            {
                i_Dictionary[i_Key].Add(i_Element);
            }
            else
            {
                i_Dictionary.Add(i_Key, new List<T>());
                i_Dictionary[i_Key].Add(i_Element);
            }
        }

        private void addPostToDictionaryByPlace(string i_PlaceName, Post i_Post)
        {
            addElementToDictionaryByKey(i_PlaceName, m_DictionaryOfPostsByPlaces, i_Post);
        }

        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        //---------------------------Fetch methods------------------------------//
        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        public void FetchPosts()
        {
            PostsCollection = new PostsCollection(m_User);
        }

        public void FetchPostsByPlaces()
        {
            FacebookObjectCollection<Post> posts = m_User.Posts;
            m_DictionaryOfPostsByPlaces.Clear();

            foreach (Post post in posts)
            {
                Page page = post.Place;
                if (page != null && page.Name != null)
                {
                    addPostToDictionaryByPlace(page.Name, post);
                }
            }
        }

        public void FetchFriends()
        {
            foreach (User friend in m_User.Friends)
            {
                m_ListOfFriends.Add(friend);
            }
        }

        public void FetchGroups()
        {
            foreach (Group group in m_User.Groups)
            {
                m_ListOfGroups.Add(group);
            }
        }

        public void FetchAlbums()
        {
            foreach (Album album in m_User.Albums)
            {
                m_ListOfAlbums.Add(album);
            }
        }

        public List<Photo> FetchPhotosByAlbumName(string i_AlbumName)
        {
            List<Photo> listOfPhotos = new List<Photo>();
            try
            {
                foreach (Album album in m_User.Albums)
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

        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        //-----------------------------Get methods------------------------------//
        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        public List<string> GetPlaceNamesOfPosts()
        {
            List<string> placesNamesList = new List<string>();

            if (m_DictionaryOfPostsByPlaces.Count != 0)
            {
                foreach (KeyValuePair<string, List<Post>> entry in m_DictionaryOfPostsByPlaces)
                {
                    string placeName = entry.Key;
                    placesNamesList.Add(placeName);
                }
            }

            return placesNamesList;
        }

        public ICollection<Post> GetAllPosts()
        {
            if (m_User.Posts.Count != 0)
            {
                return m_User.Posts;
            }
            else
            {
                return null;
            }
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

        public ICollection<Post> GetPostsByPlaceName(string i_PlaceName)
        {
            return m_DictionaryOfPostsByPlaces[i_PlaceName];
        }

        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//
        //--------------------Feature bestTimeForStatus methods-----------------//
        //----------------------------------------------------------------------//
        //----------------------------------------------------------------------//


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
            return i_GetBestTimeForStatus.GetBestTimeForStatus(m_User);
        }
    }
}
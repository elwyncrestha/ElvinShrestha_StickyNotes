using System;

namespace ElvinShrestha_StickyNotes
{
    public static class FormLoaderClass
    {
        // for storing currently active user
        private static String username;

        public static String _username
        {
            get { return username; }
            set { username = value; }
        }


        // form loading methods
        public static void loadLogin()
        {
            Login login = new Login();
            login.ShowDialog();
        }
        
        public static void loadRegisterUser()
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.ShowDialog();
        }

        public static void loadResetPassword()
        {
            ResetPassword resetPassword = new ResetPassword();
            resetPassword.ShowDialog();
        }

        public static void loadDashboard()
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        public static void loadStickyNotes()
        {
            StickyNotes stickyNotes = new StickyNotes();
            stickyNotes.ShowDialog();
        }

        public static void loadCategories()
        {
            Categories categories = new Categories();
            categories.ShowDialog();
        }

        public static void loadCreateANote()
        {
            CreateANote createANote = new CreateANote();
            createANote.ShowDialog();
        }

        public static void loadUserType()
        {
            UserType userType = new UserType();
            userType.ShowDialog();
        }

        public static void loadChangePassword()
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }

        public static void loadUserDetails()
        {
            UserDetails userDetails = new UserDetails();
            userDetails.ShowDialog();
        }

        public static void loadUserDetailAdmin()
        {
            UserDetailAdmin userDetailAdmin = new UserDetailAdmin();
            userDetailAdmin.ShowDialog();
        }

        public static void loadAboutStickyNote()
        {
            AboutStickyNote aboutStickyNote = new AboutStickyNote();
            aboutStickyNote.ShowDialog();
        }
    }
}

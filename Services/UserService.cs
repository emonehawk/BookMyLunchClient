using Microsoft.AspNetCore.Components;

namespace BookMyLunchClient.Services
{
    // this class provides userservices
    public class UserService
	{
        private readonly NavigationManager _navigator;

		public UserService(NavigationManager navigationManager)
		{
            _navigator = navigationManager;
        }

        // Creates the initial navigate for users
		public void InitialNavigate()
		{
            if (isAuthorized())
            {
                switch (getRole())
                {
                    case UserRole.Client:
                        _navigator.NavigateTo("/clienthome");
                        break;
                    case UserRole.Host:
                        _navigator.NavigateTo("/hosthome");
                        break;
                    case UserRole.Observer:
                        _navigator.NavigateTo("/observerhome");
                        break;
                    default:
                        _navigator.NavigateTo("/login");
                        break;
                }
            }
            else
            {
                _navigator.NavigateTo("/login");
            }
        }

        // gets the role of user
        private UserRole getRole()
        {
            return UserRole.Client;
        }

        // check if user is loged in
        private bool isAuthorized()
        {
            return false;
        }
    }

    // types of user
    public enum UserRole
    {
        Client,
        Host,
        Observer
    }
}


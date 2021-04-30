using System;


namespace R5T.Aalborg
{
    /// <summary>
    /// A simple username and password authentication representation.
    /// </summary>
    /// <remarks>
    /// Interface is read-only.
    /// </remarks>
    public interface IAuthentication
    {
        string Username { get; }
        string Password { get; }
    }
}

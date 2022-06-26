using App.Utility;
using App.Models.DataBase;
using App.Themes;

/// <summary>
/// Application namespace
/// </summary>
namespace App
{

/// <summary>A singleton object that controls core aspects of the app such as theme, database, and startup.</summary>
public class AppController : Singleton<AppController>
{
    /// <summary>A reference to the local database manager.</summary>
    public DBManager manager;

    /// <summary>Controls current theme and list of themes.</summary>
    public PaletteController controller;
    
    /// <summary>Called after object instantiation.</summary>
    protected override void Awake()
    {
        base.Awake();
        //Ensure object is not destroyed
        DontDestroyOnLoad(gameObject);
        //app startup code goes here

    }
}
}
using System;
namespace MyNamespace
{
  // define class
  public class MySingleton
  {
    private static string s_path = "";
    private static MySingleton s_instance = null;
    public static void Initialize (string path)
    {
      s_path = path;
    }
    public static MySingleton GetInstance ()
    {
      Console.WriteLine("instance");
      if(s_instance != null){
        return s_instance;
      }
      return s_instance = new MySingleton(s_path);
    }

    private int m_uptime;
    private string m_path;
    private MySingleton (string path)
    {
      Console.WriteLine("MySingleton ctor");
      m_path = path;
      m_uptime = 0;
    }
    public void MyMethod ()
    {
      m_uptime++;
      Console.WriteLine("MySingleton.MyMethod " + m_path);
    }
  }
}

using System;

public class Page:System.Web.UI.Page
{
	public Page{}
	public static int CurrentID
	{
		get
		{
			return Convert.ToInt32(HttpContext.Current.Request.QueryString["id"]);
		}
	}
	public static string GeFullName(string userid)
	{
		return "FullName";
	}
	public static string UserName
	{
		ge
		{
			return HttpContext.Current.User.Identity.Name;
		}
	}
	public stat bool IsAuthenticated
	{
		get
		{
			return HttpContext.Current.User.Identity.IsAuthenticated;
		}
	}
}

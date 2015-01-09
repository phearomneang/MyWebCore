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
		return this.FullName;
	}
}
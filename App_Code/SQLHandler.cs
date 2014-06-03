using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SQLHandler
/// </summary>
public class SQLHandler
{
    SqlConnection conn;

	public SQLHandler()
	{
        conn = new SqlConnection("");
	}

    public int Login(string username, string password)
    {
        return 0;
    }
}
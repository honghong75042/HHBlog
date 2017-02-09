///
//?????,?????CodeSmith??
//???:??
//????:2010?1?24?
///

using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

using Blogo.Model;
using Blogo.DBUtility;
using Blogo.IDAL;

using Blogo.SQLServerDAL;
using Blogo.AccessDAL;
using Blogo.DALFactory;



namespace Blogo.BLL
{
	///
	//Author
	///
	public static class AuthorManager
	{
		private static Blogo.IDAL.IAuthor dal=Blogo.DALFactory.DataAccess.CreateAuthor();
		
		public static  AuthorEntity SelectAuthorByID(int t_author_id)
		{
			AuthorEntity temp=null;
			try
			{
				temp=dal.SelectAuthorByID( t_author_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return temp;
		}
		
		public static IList<AuthorEntity> GetAllAuthor()
		{
			IList<AuthorEntity> temp=null;
			try
			{
				temp=GetAllAuthor();
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
		
		
		public static IList<AuthorEntity> GetAllAuthorByrole_id(int t_role_id)
		{
			IList<AuthorEntity> temp=null;
			try
			{
				temp=GetAllAuthorByrole_id(t_role_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
	
		public  static int InsertAuthor(AuthorEntity t_Author)
		{		
			int i=-1;
			try
			{
				i=InsertAuthor(t_Author);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;				
		}
		
		public static int UpdateAuthor(AuthorEntity t_Author)
		{
			int i=-1;
			try
			{
				i=UpdateAuthor(t_Author);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
		
		public static int DeleteAuthor(int t_author_id)
		{
			int i=-1;
			try
			{
				i=DeleteAuthor(t_author_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
	}
}



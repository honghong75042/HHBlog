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
	//Blogentrie
	///
	public static class BlogentrieManager
	{
		private static Blogo.IDAL.IBlogentrie dal=Blogo.DALFactory.DataAccess.CreateBlogentrie();
		
		public static  BlogentrieEntity SelectBlogentrieByID(int t_blog_id)
		{
			BlogentrieEntity temp=null;
			try
			{
				temp=dal.SelectBlogentrieByID( t_blog_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return temp;
		}
		
		public static IList<BlogentrieEntity> GetAllBlogentrie()
		{
			IList<BlogentrieEntity> temp=null;
			try
			{
				temp=GetAllBlogentrie();
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
		
		
		public static IList<BlogentrieEntity> GetAllBlogentrieByauthor_id(int t_author_id)
		{
			IList<BlogentrieEntity> temp=null;
			try
			{
				temp=GetAllBlogentrieByauthor_id(t_author_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
		
		public static IList<BlogentrieEntity> GetAllBlogentrieByblogtype_id(int t_blogtype_id)
		{
			IList<BlogentrieEntity> temp=null;
			try
			{
				temp=GetAllBlogentrieByblogtype_id(t_blogtype_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
	
		public  static int InsertBlogentrie(BlogentrieEntity t_Blogentrie)
		{		
			int i=-1;
			try
			{
				i=InsertBlogentrie(t_Blogentrie);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;				
		}
		
		public static int UpdateBlogentrie(BlogentrieEntity t_Blogentrie)
		{
			int i=-1;
			try
			{
				i=UpdateBlogentrie(t_Blogentrie);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
		
		public static int DeleteBlogentrie(int t_blog_id)
		{
			int i=-1;
			try
			{
				i=DeleteBlogentrie(t_blog_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
	}
}



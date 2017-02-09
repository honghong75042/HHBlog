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


namespace Blogo.IDAL
{
	///
	//Blogentrie
	///
	public interface IBlogentrie
	{
		 BlogentrieEntity SelectBlogentrieByID(int t_blog_id);
		
		 IList<BlogentrieEntity> GetAllBlogentrie();
				
		 IList<BlogentrieEntity> GetAllBlogentrieByauthor_id(int t_author_id);
		
		 IList<BlogentrieEntity> GetAllBlogentrieByblogtype_id(int t_blogtype_id);
		
	
		  int InsertBlogentrie(BlogentrieEntity t_Blogentrie);
		
		  int UpdateBlogentrie(BlogentrieEntity t_Blogentrie);
		
		  int DeleteBlogentrie(int t_blog_id);
	}
}



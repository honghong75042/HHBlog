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
	//Blogotype
	///
	public interface IBlogotype
	{
		 BlogotypeEntity SelectBlogotypeByID(int t_blogtype_id);
		
		 IList<BlogotypeEntity> GetAllBlogotype();
				
		 IList<BlogotypeEntity> GetAllBlogotypeByauthor_id(int t_author_id);
		
	
		  int InsertBlogotype(BlogotypeEntity t_Blogotype);
		
		  int UpdateBlogotype(BlogotypeEntity t_Blogotype);
		
		  int DeleteBlogotype(int t_blogtype_id);
	}
}



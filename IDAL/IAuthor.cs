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
	//Author
	///
	public interface IAuthor
	{
		 AuthorEntity SelectAuthorByID(int t_author_id);
		
		 IList<AuthorEntity> GetAllAuthor();
				
		 IList<AuthorEntity> GetAllAuthorByrole_id(int t_role_id);
		
	
		  int InsertAuthor(AuthorEntity t_Author);
		
		  int UpdateAuthor(AuthorEntity t_Author);
		
		  int DeleteAuthor(int t_author_id);
	}
}



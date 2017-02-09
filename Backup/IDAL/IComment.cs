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
	//Comment
	///
	public interface IComment
	{
		 CommentEntity SelectCommentByID(int t_comment_id);
		
		 IList<CommentEntity> GetAllComment();
				
		 IList<CommentEntity> GetAllCommentByblog_id(int t_blog_id);
		
	
		  int InsertComment(CommentEntity t_Comment);
		
		  int UpdateComment(CommentEntity t_Comment);
		
		  int DeleteComment(int t_comment_id);
	}
}



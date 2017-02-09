
///
//generate by CodeSmith
//created time:2010?1?24?
//Name:NN
///

using System;

namespace Blogo.Model
{
	public class BlogotypeEntity
	{
		protected int _blogtype_id;
		protected string _name = String.Empty;
		protected int _author_id;
	
		public BlogotypeEntity()
		{
			
		}
		
		public BlogotypeEntity(int blogtype_id,string name,int author_id)
		{
			_blogtype_id = blogtype_id ;	
			_name = name ;	
			_author_id = author_id ;	
		}
		
		public int  Blogtype_id
		{
			get
			{
				return _blogtype_id;
			}
			set
			{
				_blogtype_id=value;
			}				
		}
			
		public string  Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name=value;
			}				
		}
			
		public int  Author_id
		{
			get
			{
				return _author_id;
			}
			set
			{
				_author_id=value;
			}				
		}
			
	}
}



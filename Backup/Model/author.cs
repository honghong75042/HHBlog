
///
//generate by CodeSmith
//created time:2010?1?24?
//Name:NN
///

using System;

namespace Blogo.Model
{
	public class AuthorEntity
	{
		protected int _author_id;
		protected string _username = String.Empty;
		protected string _password = String.Empty;
		protected int _role_id;
		protected string _islock = String.Empty;
	
		public AuthorEntity()
		{
			
		}
		
		public AuthorEntity(int author_id,string username,string password,int role_id,string islock)
		{
			_author_id = author_id ;	
			_username = username ;	
			_password = password ;	
			_role_id = role_id ;	
			_islock = islock ;	
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
			
		public string  Username
		{
			get
			{
				return _username;
			}
			set
			{
				_username=value;
			}				
		}
			
		public string  Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password=value;
			}				
		}
			
		public int  Role_id
		{
			get
			{
				return _role_id;
			}
			set
			{
				_role_id=value;
			}				
		}
			
		public string  Islock
		{
			get
			{
				return _islock;
			}
			set
			{
				_islock=value;
			}				
		}
			
	}
}



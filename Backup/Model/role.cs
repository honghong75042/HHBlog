
///
//generate by CodeSmith
//created time:2010?1?24?
//Name:NN
///

using System;

namespace Blogo.Model
{
	public class RoleEntity
	{
		protected int _role_id;
		protected string _name = String.Empty;
	
		public RoleEntity()
		{
			
		}
		
		public RoleEntity(int role_id,string name)
		{
			_role_id = role_id ;	
			_name = name ;	
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
			
	}
}



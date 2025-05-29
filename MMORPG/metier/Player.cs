using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier
{
    /// <summary>
    /// Cette class gère les joueurs
    /// </summary>
    public class Player
    {
        #region ATTRIBUTS
        private string playerId;
        private string username;
        private string email;
        private int accountLevel;
        private DateTime creationDate;
        private bool isOnline;
        

        #endregion

        #region PROPRIETES
        /// <summary>
        /// 
        /// </summary>
        public string PlayerId
        {
            get => playerId; set => playerId = value;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Username
        {
            get => username; set => username = value;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Email
        {
            get => email; set => email = value;
        }
        public int AccountLevel => accountLevel;
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreationDate => creationDate;
        /// <summary>
        /// 
        /// </summary>
        public bool IsOnline
        {
            get => isOnline; set => isOnline = value;
        }
        #endregion  

        #region CONSTRUCTEURS
        public Player (string playerId, string username, string email,int accountLevel, DateTime creationDate, bool isOnline)
        {
            this.playerId = playerId;
            this.username = username;
            this.email = email;
            this.accountLevel = accountLevel;
            this.creationDate = creationDate;
            this.isOnline = isOnline;
              
        } 
        #endregion  

        #region METHODES
        /// <summary>
        /// 
        /// </summary>
        public void Login()
        {
            isOnline = true;
        }
        /// <summary>
        /// 
        /// </summary>
        public void Logout()
        {
            isOnline = false;
        }

        public Character CreateCharacter()
        {
            throw new NotImplementedException();
        }

        public void DeleteCharacter(Character character)
        {
            throw new NotSupportedException();
        }
        #endregion  
    }
}

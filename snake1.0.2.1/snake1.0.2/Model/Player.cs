using System;
using System.Collections.Generic;
using System.Text;

namespace snake1._0._2.Model
{
    class Player
    {
        #region Attributes
        private String nickname;
        private ulong score;
        #endregion

        #region Properties
        public String Nickname
        {
            set { this.nickname = value; }
            get { return this.nickname; }
        }
        public ulong Score
        {
            set { this.score = value; }
            get { return this.score; }
        }
        #endregion

        #region Constructors
        public Player()
        {
            this.nickname = "Solid Snake";
            this.score = 0; //Replace by the score that is store in a file with xlinq
        }
        public Player(String nickname, ulong score)
        {
            this.nickname = nickname;
            this.score = score;
        }
        #endregion

    }
}

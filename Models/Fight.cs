using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using Pokedex.Models.Weathers;

namespace Pokedex.Models
{
	/// <summary>
	/// Represents a Pokemon between two Trainers
	/// </summary>
	/// <see cref="Trainer"/>
    class Fight
    {
        #region Variables
        private Trainer _playerA;
        private Trainer _playerB;

        private Weather _weather;
        #endregion

        #region Getters + Setters
		/// <summary>
		/// The first player
		/// </summary>
        public Trainer PlayerA
        { get { return this._playerA; } }
        
		/// <summary>
		/// The second player
		/// </summary>
		/// <value></value>
		public Trainer PlayerB
        { get { return this._playerB; } }

		/// <summary>
		/// The current weather effect active
		/// </summary>
        public Weather Weather
        {
            get { return this._weather; }
            set
			{ 
				this._weather.OnExit();
				this._weather = value;
				this._weather.OnEnter();
			}
        }
        #endregion

        #region Constructors
        /// <summary>
		/// The default constructor
		/// </summary>
		/// <param name="playerA">The first player</param>
		/// <param name="playerB">The second player</param>
		public Fight
        (
            Trainer playerA,
            Trainer playerB
        )
        {
            this._playerA = playerA;
            this._playerB = playerB;

            this._weather = WeatherClear.Instance;
        }
		
		/// <summary>
		/// Superseeds the default constructor with a Weather paramater
		/// </summary>
		/// <param name="weather"></param>
		/// <inheritdoc cref="Fight(Trainer, Trainer)"/>
		public Fight
		(
			Trainer playerA,
			Trainer playerB,
			Weather weather
		) : this(playerA, playerB)
		{
			this._weather = weather;
		}
        #endregion

        #region Methods
		/// <summary>
		/// Handles the general outline of a fight
		/// </summary>
		/// <returns>The winning player</returns>
        public Trainer DoCombat()
        {
            int turn = 1;

			// While both players can still fight
            while (this._playerA.CanFight
				   && this._playerB.CanFight)
            {
                this.DoTurn();

                turn++;
            }

            return this._playerA.CanFight
                   ? this._playerA
                   : this._playerB;
            
            /* cond ? if_true : if_false */
            
            /* if (this._playerA.CanFight)
             *     return this._playerA;
             * return this._playerB;
             */
        }

		/// <summary>
		/// Handles the finer workings of a singular turn
		/// </summary>
		/// <see cref="DamageHandler.CalcDamage(PokeInstance, PokeInstance, PokeMove, Weather)"/>
		/// <see cref="Trainer.CanFight"/>
		/// <see cref="PokeInstance.TakeDamage(int)"/>
		/// <see cref="Fight.Weather"/>
        private void DoTurn()
        {
			this._weather.OnTurnStart(this);

            // Code to implement for project
            // To calc damage, use DamageHandler.CalcDamage(attacker, defender, move, this._weather);
            // To apply damage, use pokemonInstance.TakeDamage(damage)
            // To get trainer pokemons, use trainer.Pokemons
            // To check if a trainer has at least on pokemon fit for combat, use trainer.CanFight

            // You can simulate each trainer turn, or develop a simple AI to simulate the second trainer's turn
			// (simple means not like Arthur, okay ?)

			// Change the weather:
			// this.Weather = newWeather.Instance;

            this._weather.OnTurnEnd(this);
        }
        #endregion
    }
}
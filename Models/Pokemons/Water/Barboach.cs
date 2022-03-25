// https://www.pokemon.com/us/pokedex/339

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Barboach : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Barboach()); }
        }
        #endregion
        
        #region Constructors
        private Barboach()
            : base(
                339,
                "Barboach",
                "Barloche",
                TypeWater.Instance,
                TypeGround.Instance,
                4,
                19,
                "Whiskers Pokémon",
                "Pokémon Barbillon",
                "It probes muddy riverbeds with its two long whiskers. A slimy film protects its body.",
                "Il sonde les bords boueux des rivières avec ses barbillons. Un film fin et visqueux protège tout son corps.",
                50,
                48,
                43,
                46,
                41,
                60
            )
        { }
        #endregion

        #region Methods
        /// <summary>
        /// Implementation of the parent method
        /// </summary>
        /// <seealso cref="Pokemon.InitMoveList"/>
        public override void InitMoveList()
        {
            this._moveList = new List<PokeMove>();
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Spark.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(MudBomb.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Bulldoze.Instance);
        }
        #endregion
    }
}
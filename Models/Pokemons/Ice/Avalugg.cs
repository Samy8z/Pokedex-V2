// https://www.pokemon.com/us/pokedex/713

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ice
{
    internal class Avalugg : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Avalugg()); }
        }
        #endregion
        
        #region Constructors
        private Avalugg()
            : base(
                713,
                "Avalugg",
                "Séracrawl",
                TypeIce.Instance,
                20,
                5050,
                "Iceberg Pokémon",
                "Pokémon Iceberg",
                "As Avalugg moves about during the day, the cracks in its body deepen. The Pokémon’s body returns to a pristine state overnight.",
                "Les crevasses sur son dos s’approfondissent au cours de la journée, mais se comblent de nouveau pendant la nuit.",
                95,
                117,
                184,
                44,
                46,
                28
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(PowderSnow.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(RapidSpin.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(IceBall.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(IcicleSpear.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(Avalanche.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(FrostBreath.Instance);
            this._moveList.Add(HighHorsepower.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(BodyPress.Instance);
        }
        #endregion
    }
}
// https://www.pokemon.com/us/pokedex/697

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Rock
{
    internal class Tyrantrum : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Tyrantrum()); }
        }
        #endregion
        
        #region Constructors
        private Tyrantrum()
            : base(
                697,
                "Tyrantrum",
                "Rexillius",
                TypeRock.Instance,
                TypeDragon.Instance,
                25,
                2700,
                "Despot Pokémon",
                "Pokémon Tyran",
                "A single bite of Tyrantrum’s massive jaws will demolish a car. This Pokémon was the king of the ancient world.",
                "Ce Pokémon peut réduire une voiture en miettes d’un seul coup de mâchoire. Il était considéré comme le roi du monde préhistorique.",
                82,
                121,
                119,
                69,
                59,
                71
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
            this._moveList.Add(Stomp.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(DragonClaw.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ThunderFang.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(HeadSmash.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(DragonTail.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(HighHorsepower.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(PsychicFangs.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(BreakingSwipe.Instance);
            this._moveList.Add(ScaleShot.Instance);
            this._moveList.Add(MeteorBeam.Instance);
            this._moveList.Add(LashOut.Instance);
        }
        #endregion
    }
}
using MashBoxBridge.Common.Interfaces;

namespace MashBoxBridge.Common.Commands
{
    public class DeployDroneCommand : CommandBase
    {
        private readonly IDroneManager _droneManager;
        public DeployDroneCommand(IDroneManager droneManager, string actionType, string parameters = null) : base(actionType, parameters)
        {
            _droneManager = droneManager;
        }

        public override void Execute()
        {
            if(_droneManager != null)
                _droneManager.DeployDrone();
        }

        public override void Undo()
        {
            if(_droneManager != null)
                _droneManager.DisableDrone();
        }
    }
    public class PlaceMarkerCommand : CommandBase
    {
        private readonly ISessionMarker _sessionMarker;
        public PlaceMarkerCommand(ISessionMarker sessionMarker, string actionType, string parameters = null) : base(actionType, parameters)
        {
            _sessionMarker = sessionMarker;
        }

        public override void Execute()
        {
            if(_sessionMarker != null)
                _sessionMarker.Place();
        }

        public override void Undo()
        {
            //if(_sessionMarker != null)
            //    _sessionMarker.DisableDrone();
        }
    }
    public class RespawnCommand : CommandBase
    {
        private readonly ISessionMarker _sessionMarker;
        public RespawnCommand(ISessionMarker sessionMarker, string actionType, string parameters = null) : base(actionType, parameters)
        {
            _sessionMarker = sessionMarker;
        }

        public override void Execute()
        {
            if(_sessionMarker != null)
                _sessionMarker.Respawn();
        }

        public override void Undo()
        {
            //if(_sessionMarker != null)
            //    _sessionMarker.DisableDrone();
        }
    }
    
    public class PlayerEmoteCommand : CommandBase
    {
        private readonly IPlayerEmote _playerEmote;
        public PlayerEmoteCommand(IPlayerEmote playerEmote, string actionType, string parameters = null) : base(actionType, parameters)
        {
            _playerEmote = playerEmote;
        }

        public override void Execute()
        {
            if(_playerEmote != null)
                _playerEmote.Play(int.Parse(_parameters));
        }

        public override void Undo()
        {
            //if(_sessionMarker != null)
            //    _sessionMarker.DisableDrone();
        }
    }
    
}
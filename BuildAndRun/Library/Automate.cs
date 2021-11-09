using BuildAndRun.CustomException;
using System;

namespace BuildAndRun.Library {

    public class Automate {

        public Automate() {
        }

        public event EventHandler<StateChangedEventArgs> StateOfBuild_Changed;
        public event EventHandler<StateChangedEventArgs> StateOfRun_Changed;

        public Guid Id => Guid.NewGuid();

        public DateTime? ExecutedAt { get; set; } = null;
        public string FileName { get; set; } = "";
        public string Name { get; set; } = "";

        private State _stateOfBuild;
        public State StateOfBuild {
            get => _stateOfBuild;
            set {
                _stateOfBuild = value;
                OnBuildStateChanged();
            }
        }
        public virtual void OnBuildStateChanged() {
            StateOfBuild_Changed.Invoke(this, new StateChangedEventArgs(Name, ExecutedAt, StateOfBuild));
        }

        private State _stateOfRun;
        public State StateOfRun {
            get => _stateOfRun;
            set {
                _stateOfRun = value;
                OnRunStateChanged();
            }
        }
        public virtual void OnRunStateChanged() =>
            StateOfRun_Changed.Invoke(this, new StateChangedEventArgs(Name, ExecutedAt, StateOfRun));
    }
}
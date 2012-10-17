﻿/*
    This file is part of NDoctor.

    NDoctor is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    NDoctor is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with NDoctor.  If not, see <http://www.gnu.org/licenses/>.
*/
namespace Probel.NDoctor.Plugins.PathologyManager.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows;
    using System.Windows.Input;

    using AutoMapper;

    using Probel.Helpers.Data;
    using Probel.Mvvm.DataBinding;
    using Probel.NDoctor.Domain.DTO;
    using Probel.NDoctor.Domain.DTO.Components;
    using Probel.NDoctor.Domain.DTO.Objects;
    using Probel.NDoctor.Plugins.PathologyManager.Helpers;
    using Probel.NDoctor.Plugins.PathologyManager.Properties;
    using Probel.NDoctor.View.Core.Helpers;
    using Probel.NDoctor.View.Core.ViewModel;
    using Probel.NDoctor.View.Plugins.Helpers;

    /// <summary>
    /// Workbench's ViewModel of the plugin
    /// </summary>
    public class WorkbenchViewModel : BaseViewModel
    {
        #region Fields

        private Chart<string, double> chart;
        private IPathologyComponent component = PluginContext.ComponentFactory.GetInstance<IPathologyComponent>();
        private IllnessPeriodViewModel selectedIllnessPeriod;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkbenchViewModel"/> class.
        /// </summary>
        /// <param name="host">The host.</param>
        public WorkbenchViewModel()
            : base()
        {
            PluginContext.Host.NewUserConnected += (sender, e) => this.component = PluginContext.ComponentFactory.GetInstance<IPathologyComponent>();

            this.IllnessHistory = new ObservableCollection<IllnessPeriodViewModel>();
            Notifyer.ItemChanged += (sender, e) => this.Refresh();

            this.RemoveIllessPeriodCommand = new RelayCommand(() => this.RemoveIllessPeriod(), () => this.CanRemoveIllessPeriod());
        }

        #endregion Constructors

        #region Properties

        public Chart<string, double> Chart
        {
            get { return this.chart; }
            set
            {
                this.chart = value;
                this.OnPropertyChanged(() => Chart);
            }
        }

        /// <summary>
        /// Gets the illness history for the connected patient.
        /// </summary>
        public ObservableCollection<IllnessPeriodViewModel> IllnessHistory
        {
            get;
            private set;
        }

        public ICommand RemoveIllessPeriodCommand
        {
            get;
            private set;
        }

        public IllnessPeriodViewModel SelectedIllnessPeriod
        {
            get { return this.selectedIllnessPeriod; }
            set
            {
                this.selectedIllnessPeriod = value;
                this.OnPropertyChanged(() => SelectedIllnessPeriod);
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Refreshes the data for this instance.
        /// </summary>
        public void Refresh()
        {
            var history = this.component.GetIllnessHistory(PluginContext.Host.SelectedPatient);
            var viewModels = Mapper.Map<IList<IllnessPeriodDto>, IList<IllnessPeriodViewModel>>(history.Periods);

            for (int i = 0; i < viewModels.Count; i++)
            {
                viewModels[i].Refreshed += (sender, e) => this.Refresh();
            }
            this.IllnessHistory.Refill(viewModels);

            this.Chart = this.component.GetIlnessAsChart(PluginContext.Host.SelectedPatient);
        }

        private bool CanRemoveIllessPeriod()
        {
            return PluginContext.DoorKeeper.IsUserGranted(To.Write)
                && this.SelectedIllnessPeriod != null;
        }

        private void RemoveIllessPeriod()
        {
            try
            {
                var dr = MessageBox.Show(Messages.Msg_DeleteIllnessPeriod, BaseText.Question, MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (dr != MessageBoxResult.Yes) return;

                this.component.Remove(this.SelectedIllnessPeriod, PluginContext.Host.SelectedPatient);

                Notifyer.OnItemChanged(this);
            }
            catch (Exception ex) { this.Handle.Error(ex); }
            finally { InnerWindow.Close(); }
        }

        #endregion Methods
    }
}
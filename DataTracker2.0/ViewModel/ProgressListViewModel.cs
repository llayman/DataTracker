﻿/*
    Copyright 2016 Shawn Gilroy

    This file is part of DataTracker.

    Discounting Model Selector is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, version 3.

    DataTracker is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with DataTracker.  If not, see <http://www.gnu.org/licenses/gpl-3.0.html>.
*/

using DataTracker.Model;
using System.Collections.ObjectModel;

namespace DataTracker.ViewModel
{
    public class ProgressListViewModel : ViewModelBase
    {
        private ObservableCollection<ProgressMonitor> _list;
        public ObservableCollection<ProgressMonitor> AllListItems
        {
            get { return _list; }
            set
            {
                _list = value;
                OnPropertyChanged("AllListItems");
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProgressListViewModel()
        {
            AllListItems = new ObservableCollection<ProgressMonitor>();
        }

        /// <summary>
        /// Add to list
        /// </summary>
        /// <param name="mProg"></param>
        public void AddLatest(ProgressMonitor mProg)
        {
            _list.Add(mProg); 
        }

        /// <summary>
        /// Dispose
        /// </summary>
        protected override void OnDispose()
        {
            this.AllListItems.Clear();
        }        
    }
}

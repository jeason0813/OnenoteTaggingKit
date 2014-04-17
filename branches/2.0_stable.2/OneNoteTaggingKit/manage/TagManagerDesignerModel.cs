﻿using System;
using WetHatLab.OneNote.TaggingKit.common;
using WetHatLab.OneNote.TaggingKit.common.ui;

namespace WetHatLab.OneNote.TaggingKit.manage
{
    /// <summary>
    /// View model to support the design mode for the <see cref="TagManager"/> dialog
    /// </summary>
    public class TagManagerDesignerModel : ITagManagerModel
    {
        ObservableSortedList<TagModelKey, string, RemovableTagModel> _tags = new ObservableSortedList<TagModelKey, string, RemovableTagModel>();

        /// <summary>
        /// Create a new instance of the view model including some dummy data.
        /// </summary>
        public TagManagerDesignerModel()
        {
            _tags.AddAll(new RemovableTagModel[] { new RemovableTagModel(new TagPageSet("suggested tag 1")),new RemovableTagModel(new TagPageSet("suggested tag 2"))});
        }

        /// <summary>
        /// Get the collection of tags used for suggestions.
        /// </summary>
        public ObservableSortedList<TagModelKey, string, RemovableTagModel> SuggestedTags
        {
            get
            {
                return _tags;
            }
        }

        /// <summary>
        /// Get the version string for the addin
        /// </summary>
        public string AddinVersion
        {
            get { return "1.2.3.4"; }
        }

        public string FrameworkVersion
        {
            get { return Environment.Version.ToString(); }
        }


        public string Logfile
        {
            get { return TraceLogger.LogFile; }
        }
    }
}
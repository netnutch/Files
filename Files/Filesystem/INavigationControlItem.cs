﻿using System;
using Windows.UI.Xaml.Media.Imaging;

namespace Files.Filesystem
{
    public interface INavigationControlItem : IComparable<INavigationControlItem>
    {
        public SvgImageSource Icon { get; }

        public string Text { get; }

        public string Path { get; }

        public SectionType Section { get; }

        public string HoverDisplayText { get; }

        public NavigationControlItemType ItemType { get; }
    }

    public enum NavigationControlItemType
    {
        Header,
        Drive,
        LinuxDistro,
        Location,
        CloudDrive
    }

    public enum SectionType
    {
        Home,
        Favorites,
        Library,
        Drives,
        CloudDrives,
        Network,
        WSL
    }
}
﻿#region Usings

using OneHundredAndEightyCore.Common;
using OneHundredAndEightyCore.Game;
using OneHundredAndEightyCore.Recognition;

#endregion

namespace OneHundredAndEightyCore.Windows.Score
{
    public interface IScoreWindow
    {
        void Show();
        void Close();
        WindowSettings GetWindowSettings();
        void SetSemaphore(DetectionServiceStatus status);
        void SetThrowNumber(ThrowNumber number);
        void AddPointsTo(Player player, int pointsToAdd);
        void SetPointsTo(Player player, int pointsToSet);
        void CheckoutShowOrUpdateFor(Player player, string hint);
        void CheckoutHideFor(Player player);
        void ThrowPointerSetOn(Player player);
        void AddLegsWonTo(Player player);
        void SetLegsWonTo(Player player, int legsToSet);
        void AddSetsWonTo(Player player);
        void OnLegPointSetOn(Player player);
    }
}
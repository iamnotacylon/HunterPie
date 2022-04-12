﻿using HunterPie.Core.Client;
using HunterPie.Core.Client.Configuration.Overlay;
using HunterPie.UI.Overlay;
using HunterPie.UI.Overlay.Widgets.Abnormality.View;
using HunterPie.UI.Overlay.Widgets.Abnormality.ViewModel;

namespace HunterPie.Features.Debug
{
    internal class AbnormalityWidgetMocker : IWidgetMocker
    {
        public void Mock()
        {
            if (ClientConfig.Config.Debug.MockAbnormalityWidget)
            {
                var mockSettings = new AbnormalityWidgetConfig();
                WidgetManager.Register<AbnormalityBarView, AbnormalityWidgetConfig>(
                    new AbnormalityBarView(ref mockSettings)
                    {
                        DataContext = new MockAbnormalityBarViewModel()
                    }
                );
            }
        }
    }
}

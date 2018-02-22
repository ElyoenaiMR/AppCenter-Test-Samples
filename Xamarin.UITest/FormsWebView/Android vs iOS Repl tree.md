# Android output
```
>>> tree                                                                        
[[object CalabashRootView] > DecorView]                                         
  [LinearLayout > FrameLayout]
    [FitWindowsFrameLayout] id: "action_bar_root"
      [ContentFrameLayout > ... > PlatformRenderer] id: "content"
        [NavigationPageRenderer] id: "NoResourceEntry-1"
          [PageContainer > TabbedPageRenderer] id: "NoResourceEntry-3"
            [FormsViewPager] id: "NoResourceEntry-2"
              [PageContainer] id: "NoResourceEntry-17"
                [PageRenderer > Platform_DefaultRenderer] id: "NoResourceEntry-14"
                  [LabelRenderer]
                    [FormsTextView] id: "NoResourceEntry-15" text: "WebView"
                  [WebViewRenderer]
                    [WebView] id: "NoResourceEntry-16"
                      [dom] id: "__w2_vvQENiR_mweb_lookup_bar_back_button"
                      [dom] id: "__w2_vvQENiR_mweb_lookup_bar_input"
                      [dom] id: "__w2_LsYUfTb_anon_checkbox"
            [TabLayout > TabLayout$SlidingTabStrip] id: "sliding_tabs"
              [TabLayout$TabView]
                [AppCompatTextView] text: "Browse"
              [TabLayout$TabView]
                [AppCompatTextView] text: "About"
              [TabLayout$TabView]
                [AppCompatTextView] text: "WebViewPage"
          [Toolbar] id: "toolbar"
            [AppCompatTextView] text: "WebViewPage"
  [View] id: "navigationBarBackground"
  [View] id: "statusBarBackground"
```


# iOS output
```
>>> tree                                                                                                                                 
[CalabashRootView > ... > UILayoutContainerView]                                                                                   
  [UITransitionView > ... > UILayoutContainerView]
    [UINavigationTransitionView > ... > Xamarin_Forms_Platform_iOS_Platform_DefaultRenderer]
      [Xamarin_Forms_Platform_iOS_LabelRenderer]
        [UILabel] label: "WebView",  text: "WebView"
      [Xamarin_Forms_Platform_iOS_WebViewRenderer > ... > dom]
        [dom] id: "page_wrapper" (center not on screen)
          [dom] id: "main_page_wrapper" (center not on screen)
            [dom > dom] id: "header"
              [dom]
                [dom]
                [dom]
                  [dom > dom] id: "__w2_NboO9Hl_view_in_app"
                  [dom > dom] id: "__w2_Qb5sG9t_signup_button"
              [dom] id: "mweb_new_stories_button_wrapper"
            [dom > dom] id: "AwWjyK"
              [dom] id: "fGGPWC"
              [dom > dom] id: "qlxmNT"
                [dom] id: "question_topics"
                  [dom] id: "GaBRRp"
                    [dom] id: "__w2_MskxQmw_topics_list"
                      [dom] id: "ZImTfi"
                        [dom] id: "__w2_e03y8lt__truncated"
                          [dom] id: "ncdGzP"
                            [dom] id: "__w2_TB7JcWI_topic_list_item"
                              [dom] id: "wlSfqU"
                                [dom > dom] id: "__w2_qQ09UAs_link"
                                  [dom] id: "iArGtZ"
                                    [dom > dom] id: "__w2_smQWmrF_card"
                          [dom] id: "XAZudp"
                            [dom] id: "__w2_LEHkWce_topic_list_item"
                              [dom] id: "xOqCzv"
                                [dom > dom] id: "__w2_IjPYoZe_link"
                                  [dom] id: "TnLrtv"
                                    [dom > dom] id: "__w2_Y96VixI_card"
                          [dom] id: "ZlUpLg"
                            [dom] id: "__w2_UPE2XNN_topic_list_item"
                              [dom] id: "ziitLE"
                                [dom > dom] id: "__w2_ObqR316_link"
                                  [dom] id: "vASqhF"
                                    [dom > dom] id: "__w2_ctlfIBI_card"
                          [dom] id: "DsZDSb" (center not on screen)
                            [dom] id: "__w2_uXS0bYf_topic_list_item" (center not on screen)
                              [dom] id: "QauiJO"
              [dom > dom]
                [dom] id: "AWuEVj"
                  [dom > ... > dom] id: "__w2_bn6oeZN_question_text"
              [dom] id: "hWCZMW"
            [dom] (center not on screen)
              [dom > dom] id: "aZEdXQ"
                [dom] id: "DCBGoV"
                [dom] id: "WfRxCs"
                [dom] id: "mMbqeu"
                [dom] id: "LPDHFx"
                [dom] id: "KYYPjH"
                [dom] id: "LhvHXO"
                [dom] id: "iPSqJX"
                [dom] id: "BkrVrL"
                [dom] id: "uXxchq"
                [dom] id: "BnNWNz"
                [dom] id: "OkmdiI"
                [dom] id: "ZKUaBA"
                [dom] id: "JhHjAL"
                [dom] id: "WOttXg"
                  [dom] id: "__w2_dHaiTMY_actionable"
                    [dom > dom] id: "__w2_dHaiTMY_wrapper"
                      [dom] id: "__w2_ZwgBUvc_content_wrapper"
                        [dom]
                          [dom]
                            [dom > ... > dom] id: "__w2_bZzpsgn_link"
                          [dom]
                            [dom] id: "tHHaIW"
                        [dom > dom] id: "__w2_gt3enL9_link"
                          [dom > ... > dom] id: "__w2_eCATMq9_wrapper"
                          [dom > ... > dom] id: "__w2_Tlu6GE1_wrapper"
                        [dom]
                          [dom] id: "__w2_T9xZV31_wrapper"
                            [dom > dom] id: "__w2_jV1m0pg_link"
              [dom] id: "UdYYBf"
              [dom > ... > dom] id: "yLDtkL"
              [dom] (center not on screen)
                [dom] id: "__w2_ZCN7n7D_paged_list" (center not on screen)
                  [dom] id: "__w2_ZCN7n7D_paged_list_wrapper" (center not on screen)
                    [dom] id: "TwmynA" (center not on screen)
                      [dom] id: "__w2_ecQNShH_actionable" (center not on screen)
                        [dom] id: "jrrWmS"
                          [dom] id: "zHstXy" (center not on screen)
                            [dom > ... > dom] id: "__w2_hJ1QQfp_answer" (center not on screen)
                              [dom > ... > dom] id: "JarkkW" (center not on screen)
                                [dom > dom]
                                  [dom] id: "RsgfZO" (center not on screen)
                                    [dom] id: "__w2_vE6UEFR_link" (center not on screen)
                                      [dom > dom] id: "__w2_juZzZU3_link" (center not on screen)
                                [dom > ... > dom] (center not on screen)
                                  [dom] id: "CIXlnE" (center not on screen)
                                    [dom] id: "CqBdjY"
                                      [dom] id: "__w2_xq5Ftuc_link"
                                        [dom > dom] id: "__w2_xq5Ftuc_name_link"
    [UINavigationBar] id: "Xamarin_Forms_Platform_iOS_NavigationRenderer_ParentingView"
      [_UIBarBackground > UIImageView]
      [_UINavigationBarContentView]
  [UITabBar]
    [_UIBarBackground]
      [UIImageView]
      [UIVisualEffectView]
        [_UIVisualEffectBackdropView]
        [_UIVisualEffectSubview]
    [UITabBarButton] label: "Browse"
      [UITabBarSwappableImageView] id: "tab_feed.png"
      [UITabBarButtonLabel] label: "Browse",  text: "Browse"
    [UITabBarButton] label: "About"
      [UITabBarSwappableImageView] id: "tab_about.png"
      [UITabBarButtonLabel] label: "About",  text: "About"
    [UITabBarButton] label: "WebViewPage"
      [UITabBarSwappableImageView] id: "tab_feed.png"
      [UITabBarButtonLabel] label: "WebViewPage",  text: "WebViewPage"
```





   M S B A M L   `   `   `  ����K  GWindowStoreClone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WindowStoreClone.PagesWindowStoreClone.Pages  5      M+clr-namespace:WindowStoreClone.UserControlsWindowStoreClone.UserControls  5      !    WindowStoreClone.Pages.Main   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:WindowStoreClone.Pages     5      :uc+clr-namespace:WindowStoreClone.UserControls     5        N� Title$
  Main��5
      .��5      � -   5        $��MainWindowMainGrid��5       � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��35 �6   �� 5      $
��0.6* �6   �� 5      $
��0.4* �6   �� 5      $��35 �6   .+�5   
   �� -   5        $��MainTabControl��5      $y�Visible=�5      $��0��5      $��1��6   $��2��5      $��2��6   }�. .@�5       �� -   5        $��HomeTab��5    $   $
��Home��6   .��5"      �� -   5        $��MainScrollViewer��5"      $��10 10 10 10q�5#      $��Visible=�5$      $��Hidden=�5%      .��5&      �� -   5        $��MainStackPanel��5'      $	��Top=�5(      $
��Left=�5)      $y�Visible=�5*      ��5+      ��  �� ElementName$ MainScrollViewer�� �� Path$ ActualWidth�.+�5.      +   %WindowStoreClone.UserControls.TopApps  -   5          Name$ TopApps��5.   %   $
��Left=�5/   %   $��2q�51   %   ��50   %   �� $ MainScrollViewer��$ ActualWidth�51   %   �� 55      $��Featured Apps��57      $��40(�58      $��10q�59      $
��Left=�5:      5;       -   'WindowStoreClone.UserControls.AppViewer  5<      -   5          Name$ FeaturedAppsViewer��5<   '   $
��Left=�5=   '   $��2q�5?   '   ��5>   '   �� $ MainScrollViewer��$ ActualWidth�5?   '   �� 5A      $��Top Apps��5B      $��40(�5C      $��10q�5D      $
��Left=�5E      5F         5G      -   5        $ TopAppsViewer��5G   '   $
��Left=�5H   '   $��2q�5J   '   ��5I   '   �� $ MainScrollViewer��$ ActualWidth�5J   '   �� 5L      $��	Top Games��5M      $��40(�5N      $��10q�5O      $
��Left=�5P      5Q         5R      -	   5        $ TopGamesViewer��5R   '   $
��Left=�5S   '   $��2q�5U   '   ��5T   '   �� $ MainScrollViewer��$ ActualWidth�5U   '   �� 5W      $��Collections��5X      $��40(�5Y      $��10q�5Z      $
��Left=�5[      5\         5]      -
   5        $ CollectionsViewer��5]   '   $
��Left=�5^   '   $��2q�5`   '   ��5_   '   �� $ MainScrollViewer��$ ActualWidth�5`   '   5a      5b      5d      �� 5f      -   5        $��	GamingTab��5f   &   $��Gaming��6   .��5g      �� -   5        $��GamingStackPanel��5h      $	��Top=�5i      $
��Left=�5j      $y�Visible=�5k      ��5l      �� $ MainScrollViewer��$ ActualWidth�.+�5n      �� $��Gaming��5o      $��40(�5p      $��10q�5q      $
��Left=�5r      5s         5t      -   5        $ GamingViewer��5t   #   $
��Left=�5u   '   $��2q�5w   '   ��5v   '   �� $ MainScrollViewer��$ ActualWidth�5w   '   5x      5y      �� 5{      -   5        $��EntertainmentTab��5{   -   $��Entertainment��6   .��5|      �� -   5        $��EntertainmentStackPanel��5|      $	��Top=�5}      $
��Left=�5~      $y�Visible=�5      ��5�      �� $ MainScrollViewer��$ ActualWidth�.+�5�      �� $��Entertainments��5�      $��40(�5�      $��10q�5�      $
��Left=�5�      5�         5�      -   5        $ EntertainmentViewer��5�   #   $
��Left=�5�   '   $��2q�5�   '   ��5�   '   �� $ MainScrollViewer��$ ActualWidth�5�   '   5�      5�      �� 5�      -   5        $��ProductivityTab��5�   ,   $��Productivity��6   .��5�      �� -   5        $��ProductScrollView��5�      $��Visible=�5�      $��Hidden=�5�      $��10 10 10 10q�5�      .��5�      �� -   5        $��ProdcutStackPanel��5�      $	��Top=�5�      $
��Left=�5�      $y�Visible=�5�      ��5�      �� $ MainScrollViewer��$ ActualWidth�.+�5�      7   1WindowStoreClone.UserControls.ProductivityTopApps  -   5          Name$ Productivity��5�   1   $
��Left=�5�   -   $��2q�5�   -   ��5�   -   �� $ MainScrollViewer��$ ActualWidth�5�   -   �� 5�      $��Special Apps��5�      $��40(�5�      $��10q�5�      $
��Left=�5�      5�         5�      -   5        $ SpecialAppsViewer��5�   '   $
��Left=�5�   '   $��2q�5�   '   ��5�   '   �� $ MainScrollViewer��$ ActualWidth�5�   '   5�      5�      5�      �� 5�      -   5        $��DealsTab��5�   %   $��Deals��6   .��5�      �� -   5        $��DealsStackPanels��5�      $	��Top=�5�      $
��Left=�5�      $y�Visible=�5�      ��5�      �� $ MainScrollViewer��$ ActualWidth�.+�5�      �� $��
Deals Apps��5�      $��40(�5�      $��10q�5�      $
��Left=�5�      5�         5�      -   5        $ DealsAppsViewer��5�   #   $
��Left=�5�   '   $��2q�5�   '   ��5�   '   �� $ MainScrollViewer��$ ActualWidth�5�   '   5�      5�      5�      5�      5�      
   M S B A M L   `   `   `  ����G  CFasetto.Word, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Fasetto.WordFasetto.Word  5      L HFasetto.Word.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:Fasetto.Word.Core;assembly=Fasetto.Word.CoreFasetto.Word.Core 5      &     Fasetto.Word.ChatListItemControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Fasetto.Word     5      Kcore:clr-namespace:Fasetto.Word.Core;assembly=Fasetto.Word.Core     5        � 	Resources  5
         ContentStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name  ForegroundLightBrush �Name � ColumnDefinitions  WordRedBrush �� 	Converter/   )Fasetto.Word.BooleanToVisibilityConverter	 �� ConverterParameter
 �� Padding,   &Fasetto.Word.StringRGBToBrushConverter �� RelativeSource �� CornerRadius  FontSizeLarge  LatoRegular �� Padding  WordBlueBrush  ForegroundDarkBrush �� Triggers :� RoutedEvent  WordUltraLightBlue	 �� To g� Duration �� 
TargetName �� TargetProperty �� Value �� Binding �� 
TargetName  WordUltraLightBlueBrush��%�  &	        7  7  7  7  7  7  7  7  7  7  7  �� 5   
   " ��6%   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ 
background��6!   8��  ._�5      � $ 	container��6#   
������  5   "   �� 5   &   $
��Auto �67   �� 5   &   $��* �67   .+�5   "   �� 8�� $��4��5   %   $
��Left=�5   %   y�5   %   �� *NewContentAvailable+   $
	 True���� 5!   "   $��0��6)   $

 8 15q�5"   )   ._�5$   &   �� $��40��5%   -   ��5$   -   �� *ProfilePictureRGB+   ��5&   )   �� *ActualHeight+ �� *Self+ 5'   )   �� *ActualHeight+ �� *Self+._�5)   *   �� $��Center=�5*   1   $��Center=�5+   1   8�� 8�� 8�� ��5)   4   �� *
Initials+5.   1   5/   '   50   #   �� 53   "   $��1��6)   $
 0 0 8 0q�69   ._�54   &   �� $��Center=�61   .+�56   *   �� $ 0 0 0 2q�57   1   8�� 8�� ��56   4   �� *Name+59   1   �� 5;   *   $ 0 2 0 0q�5<   1   8�� $��CharacterEllipsis=�5>   1   8�� ��5;   4   �� *	Message+5?   1   5@   '   5A   #   5B      5C       5F      :� 5G      $ 
MouseEnter��6+   .[�5H   "   �� .��5I   &   �� .��5J   *   �� 8 	 $ 0:0:0.3D�6b   $ 	container��6u   $ Background.Color�6�   5K   '   5L   #   5M      :� 5N      $ 
MouseLeave��6+   .[�5O   "   �� .��5P   &   �� .��5Q   *   �� $ TransparentX�69   $ 0:0:0.3D�6J   $ 	container��6]   $ Background.Color�6   5R   '   5S   #   5T      �� 5U      $
 True��6I    6*   �� *
IsSelected+.a�5V   "   �� $ 
background��6?   8 
  � ��6W   5W      5Y      5[      5\      5]      .��5_      �� #��[  5`      5c      
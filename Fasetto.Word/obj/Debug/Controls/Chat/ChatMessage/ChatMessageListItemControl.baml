   M S B A M L   `   `   `  ����G  CFasetto.Word, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Fasetto.WordFasetto.Word  5      L HFasetto.Word.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:Fasetto.Word.Core;assembly=Fasetto.Word.CoreFasetto.Word.Core 5      -    'Fasetto.Word.ChatMessageListItemControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Fasetto.Word     5      Kcore:clr-namespace:Fasetto.Word.Core;assembly=Fasetto.Word.Core     5      .��5	      ��   �� Padding$  5q�6   ._�5   
   � .+�5      �� $	��Top=�6   $
��Left=�5      $��0 5 0 5q�5      $��35��5      
��� � �   ForegroundLightBrush#��[  5      $��1q�5      y�5      �� *
SentByMe+ �� 	Converter /   )Fasetto.Word.BooleanToVisibilityConverter   �� CornerRadius 5      �� *ActualWidth+ �� RelativeSource �� *Self+��5      �� *ActualWidth+ �� *Self+._�5      �� $��Center=�5      $��Center=�5      #��[  5        LatoBold#��[ 5      ��5      �� *
Initials+5      5       � 5#      $��	25 0 25 0q�6   ��5$      �� *
SentByMe+ /   )Fasetto.Word.SentByMeToAlignmentConverter   � Triggers 5&      :� 5(       :� RoutedEvent$ 
MouseEnter��6#   .[�5)      �� .��5*      ��  �� 
TargetName$ ExtraDetails��6)    �� TargetProperty$ Opacity�6N   .��5+   "   W� 	 W� To$ 1X�62   	 g� Duration$	 
00:00:00.5D�69   5,      5-      5.      :� 50      $ 
MouseLeave��6#   .[�51      �� .��52      �� $ ExtraDetails��6)   $ Opacity�6N   .��53   "   W� $ 0X�62   $	 
00:00:00.5D�69   54      55      56      
 � RowDefinitions
 58      �� 59      $��* �6$   �� 5:      $
��auto �6$   �� 5;      $
��auto �6$   .+�5>      �� $ 10��6   $  15q�5?      ��5@      �� *
SentByMe+ 0   *Fasetto.Word.SentByMeToBackgroundConverter  ._�5D      �� $��Center=�6    $
��Wrap=�5E        LatoRegular#��[ 5F        WordDarkBlueBrush#��[ 5G      ��5H      �� *	Message+5J      F� 5M      $��1��6   $��
15 -1 15 0q�5N      $��0��5O       K� ZIndex$ 1��5P      +����        р�� ��� � -1    �        	��5Q      �� *
SentByMe+   ��5S      �� *
SentByMe+   �� 5V      -   5         ��Name$ ExtraDetails��5V      $��2��63    �� Orientation$ 
Horizontal=�5W       J� Opacity$ 0Q�5Y      ��5X      �� *
SentByMe+    �� ConverterParameter$
 True��.+�5[      �� $��2��5\      #��[  5]        FontSizeSmaller#��[ 5^      #��[ 5_      $��0 0 15 0q�5`      ��5[       �� *MessageSentTime+ -   'Fasetto.Word.TimeToDisplayTimeConverter  5`      �� 5b      $��2��5c      #��[ 5d      #��[ 5e      #��[ 5f      ��5b       �� *MessageReadTime+ *   $Fasetto.Word.TimeToReadTimeConverter  5f      5h      5i      5j      5k      5l      
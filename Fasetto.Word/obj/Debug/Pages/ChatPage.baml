   M S B A M L   `   `   `  ����G  CFasetto.Word, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Fasetto.WordFasetto.Word  5      L HFasetto.Word.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:Fasetto.Word.Core;assembly=Fasetto.Word.CoreFasetto.Word.Core 5          Fasetto.Word.ChatPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Fasetto.Word     5      Kcore:clr-namespace:Fasetto.Word.Core;assembly=Fasetto.Word.Core     5      -   5           Fasetto.Word.BasePage`1   Name$
  Page��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� 
������ $��2��5       K� ZIndex$ 1��5      y�5      �� *AnyPopupVisible+ �� 	Converter /   )Fasetto.Word.BooleanToVisibilityConverter   �� ConverterParameter$
 true�� J� InputBindings 5      d� 5       d� MouseAction$ 	LeftClicke�6    �� Command 67   �� *PopupClickAwayCommand+5      � 5    
   $��50��6    � ColumnDefinitions 5"      �� 5#      $��* �6#   �� 5$      $
��Auto �6#   .+�5(      �� $��Parnell��6      ForegroundLightBrush#��[  5)        FontSizeXLarge#��[ 5*        LatoRegular#��[ 5+      $��Center=�5,      $��Center=�5-      $��2��5.      �� 51      	 �� Orientation$	 
Horizontal=�6   $��1��62   .+�52      ��   IconGrowButton#��[ 6     FontAwesomeSearchIcon#��[ 6A   �� 53      #��[ 6    # FontAwesomeEllipsisVerticalIcon#��[ 6A   54      55      )   #Fasetto.Word.ChatMessageListControl  58   
   $��1��6'       Fasetto.Word.BubbleContent  5;   
   $��1��6   $ 2��5<      $��Bottom=�5>      $
��Left=�5?      
 � DataContext
 5=      �� *AttachmentPopupMenu+�   �Fasetto.Word.BaseAttachedProperty`2[[Fasetto.Word.AnimateSlideInFromBottomProperty, Fasetto.Word, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 5@      �� *!ViewModel.AttachmentMenuVisible+ �� RelativeSource ��  �� AncestorType   Fasetto.Word.ChatPage"  � 5C   
   $��2��6   $ 3��5D      $��50��5E      $	��114��5F      #��[  5G       5H      �� 5J      $
��Auto �6#   �� 5L      $��* �6#   �� 5N      $
��Auto �6#   .+�5R      �� #��[ 6     FontAwesomePaperClipIcon#��[ 5T        ForegroundDarkBrush#��[ 5U      $	��Top=�5V      ��5S      �� *	MinHeight+ �� $
 GridL���5W      �� *AttachmentButtonCommand+�� 5[      $��1��6   
 � Tag$ Write a message...��5\        FontSizeRegular#��[ 5]      $��Center=�5^      $
��0 10q�5_      $��0q�5`       �� AcceptsReturn .  �� 
AcceptsTab . " �� VerticalScrollBarVisibility$
 Auto=�5c      �� 5g      $��2��6   $	 
Horizontal=�5h      $	��Top=�5i      $��0 0 8 0q�5j      .+�5m      �� #��[ 6    	 FontAwesomeEmojiIcon#��[	 5o       
 WordOrangeBrush#��[
 5p      ��5n      �� *	MinHeight+ �� $
 GridL�5p      �� 5s      $
��Send��6   $��8q�5t      #��[ 5u        WordGreenBrush#��[ 5v      ��5w      �� *SendCommand+5x      5y      5z      5|      
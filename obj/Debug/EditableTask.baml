   M S B A M L   `   `   `  ����N  JScrumBoardNewDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ScrumBoardNewDesignScrumBoardNewDesign  5      &     ScrumBoardNewDesign.EditableTask   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:ScrumBoardNewDesign     5      -   5        .��5      � -   5          �Name$  collapsedGrid��5      $��60��6"   $��Center=�6.   $��Stretch=�6I   $	��150��6g   .+�5	   
   �� $��1q�6   $��Stretch=�6%   $	��Top=�6C   ���#FF5754 �� CornerRadius$ 10��6p   $
��Auto��6�   $��60��6�   ._�5      � -   5        $  mainGrid��5      .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   $��Center=�6Q   .+�5      � .+�5      �� -   5         ��Name$ titleTextBlock��5   $   $��Enter a name...��6<   
�������$	��120��6f   $
��Wrap=�6u   $��Center=�6�   $��	Helvetica)�6�   $��Light"�6�   �� 5      -   5         ��Name$ titleTextBox��5   "   $y�	Collapsed=�68   $��77��6O   $��Center=�6|   5      5      9� 5      -   5         9�Name$ expander��5      
�������$
��Info��6@   $��23��6N   $��Bottom=�6�   $��	Helvetica)�6�   $��Light"�6�   .��5      � -   5        $
  grid��5      .+�5      �� -   5         ��Name$ infoBackBorder��5   !   ���#1C263B$ 10��6N   $��0,3,0,0q�6`   �� 5      $
��Left=�6'   $	��Top=�6B   $
��Auto=�6�   ��6Z   �� *ActualWidth+ �� ElementName$
 grid�� �� Mode$ OneWay=�.��5      � -	   5        $  grid1��5   #   .+�5   "   �� -
   5        $ 	textBlock��5   ,   $
��Wrap=�6?   $��6,1,0,0q�6S   $��	Helvetica)�6   $��Light"�6�   �� 5   "   -   5        	 ��Name$	 richTextBox��5   .   $
��Left=�6C   $	��Top=�6^   $y�Hidden=�6�   $��
0,0,-196,0q�6�   ��6v   �� *ActualHeight+$
 grid��$ OneWay=���6�   �� *ActualWidth+$ grid1��$ OneWay=�6  5      5      5      5      5      5      � 5   
   -   5        $  gridDeleteButton��5      $��15��6)   $��15��64   $��Right=�6@   $	��Top=�6\   $��0,5,5,0q�6t   
 �� BitmapScalingMode$
 HighQuality=�6�   $y�	Collapsed=�6�   ��5       �� 5!       �� ImageSource$ /assets/delete icon.png��6   .+�5#      �� -   5         ��Name$ deleteButton��5#      $�� ��6+   $
��Left=�66   $	��Top=�6Q   ���	#00DDDDDD���	#00707070���	#00000000 J� Opacity$	 0.1Q�6  ��6i   �� *ActualWidth+$ gridDeleteButton��$ OneWay=���6   �� *ActualHeight+$ gridDeleteButton��$ OneWay=�5%      5'      5(      
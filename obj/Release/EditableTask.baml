   M S B A M L   `   `   `  ���� N  JScrumBoardNewDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ScrumBoardNewDesignScrumBoardNewDesign  &     ScrumBoardNewDesign.EditableTask   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:ScrumBoardNewDesign     -   .��� -     �Name$  collapsedGrid��$��60��$��Center=�$��Stretch=�$	��150��.+��� $��1q�$��Stretch=�$	��Top=����	#B2B90000 �� CornerRadius$ 10��$
��Auto��$��60��._�� -   $  mainGrid��.+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+�� .+��� -    ��Name$ titleTextBlock��$��Enter a name...��$	��120��$
��Wrap=�$��Center=�$��	Helvetica)�$��Light"��� -    ��Name$ titleTextBox��$y�	Collapsed=�$��77��$��Center=�9� -    9�Name$ expander��$
��Info��$��23�� J� Opacity$	 0.7Q�$��Bottom=�$��	Helvetica)�$��Light"�.��� -   $
  grid��.+��� ���	#FFE5E5E5$ 10���� $
��Left=�$	��Top=�$
��Auto=����� *ActualWidth+ �� ElementName$
 grid�� �� Mode$ OneWay=�.��� -   $  grid1��.+��� -	   $ 	textBlock��$
��Wrap=�$��6,1,0,0q�$��	Helvetica)�$��Light"��� -
   	 ��Name$	 richTextBox��$
��Left=�$	��Top=�$y�Hidden=�$	 0.7Q�$��
0,0,-196,0q����� *ActualHeight+$
 grid��$ OneWay=����� *ActualWidth+$ grid1��$ OneWay=�� -   $  gridDeleteButton��$��15��$��15��$��Right=�$	��Top=�$��0,5,5,0q�
 �� BitmapScalingMode$
 HighQuality=�$y�	Collapsed=�����  �� ImageSource$ /assets/delete icon.png��.+��� -    ��Name$ deleteButton��$�� ��$
��Left=�$	��Top=����	#00DDDDDD���	#00707070���	#00000000$	 0.1Q����� *ActualWidth+$ gridDeleteButton��$ OneWay=����� *ActualHeight+$ gridDeleteButton��$ OneWay=�
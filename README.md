# Taxonomy Posts Widget for Orchard Core

An Orchard Core module that provides a widget that will display the latest posts (content items) from taxonomy items. For example, you can use this widget to display posts from 'travel' tag. 

## Why ?
During the development of my site I noticed that Orchard Core lacks a widget that would just list content items that are attached to taxonomies. I have a glossary and some terms are related to topics, so this widget is created so I can easily add topics on various places on the site. Also, there are news tags or categories and many other use cases.

## How to use ?
You can place this widget easily in Design > Widgets or in WidgetsListPart or in FlowPart or anywhere where builtin Widgets could be placed.

There are three fields available:

**Taxonomy ID**:  An ID of your Content Type that is used as a Taxonomy.  *Category, Tag, Topic ...*

**Taxonomy Item ID**: An ID of item of your taxonomy. So if you have a tag named 'travel', you will put the ID of that tag here.

**Max Items**:  How many items you want to display.

## Contributions

This is my first module for Orchard Core and I am aware there could be some bugs or general-issues regarding the implemenation. I would like to see how this module could be improved.

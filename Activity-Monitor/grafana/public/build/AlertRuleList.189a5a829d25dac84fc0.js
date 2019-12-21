(window.webpackJsonp=window.webpackJsonp||[]).push([[2],{JRIL:function(e,t,a){"use strict";a.r(t),function(e){a.d(t,"AlertRuleList",function(){return g});var n=a("mrSG"),r=a("q1tI"),l=a.n(r),s=a("0cfB"),i=a("/MKj"),o=a("ZGyg"),c=a("YAXX"),u=a("Xmxp"),m=a("3SGO"),p=a("lzJ5"),d=a("4vLh"),h=a("lPMX"),f=a("EKT6"),g=function(e){function t(){var t=null!==e&&e.apply(this,arguments)||this;return t.stateFilters=[{text:"All",value:"all"},{text:"OK",value:"ok"},{text:"Not OK",value:"not_ok"},{text:"Alerting",value:"alerting"},{text:"No Data",value:"no_data"},{text:"Paused",value:"paused"},{text:"Pending",value:"pending"}],t.onStateFilterChanged=function(e){t.props.updateLocation({query:{state:e.target.value}})},t.onOpenHowTo=function(){u.b.emit("show-modal",{src:"public/app/features/alerting/partials/alert_howto.html",modalClass:"confirm-modal",model:{}})},t.onSearchQueryChange=function(e){t.props.setSearchQuery(e)},t.onTogglePause=function(e){t.props.togglePauseAlertRule(e.id,{paused:"paused"!==e.state})},t.alertStateFilterOption=function(e){var t=e.text,a=e.value;return l.a.createElement("option",{key:a,value:a},t)},t}return n.c(t,e),t.prototype.componentDidMount=function(){this.fetchRules()},t.prototype.componentDidUpdate=function(e){e.stateFilter!==this.props.stateFilter&&this.fetchRules()},t.prototype.fetchRules=function(){return n.b(this,void 0,void 0,function(){return n.d(this,function(e){switch(e.label){case 0:return[4,this.props.getAlertRulesAsync({state:this.getStateFilter()})];case 1:return e.sent(),[2]}})})},t.prototype.getStateFilter=function(){var e=this.props.stateFilter;return e?e.toString():"all"},t.prototype.render=function(){var e=this,t=this.props,a=t.navModel,n=t.alertRules,r=t.search,s=t.isLoading;return l.a.createElement(o.a,{navModel:a},l.a.createElement(o.a.Contents,{isLoading:s},l.a.createElement("div",{className:"page-action-bar"},l.a.createElement("div",{className:"gf-form gf-form--grow"},l.a.createElement(f.a,{labelClassName:"gf-form--has-input-icon gf-form--grow",inputClassName:"gf-form-input",placeholder:"Search alerts",value:r,onChange:this.onSearchQueryChange})),l.a.createElement("div",{className:"gf-form"},l.a.createElement("label",{className:"gf-form-label"},"States"),l.a.createElement("div",{className:"gf-form-select-wrapper width-13"},l.a.createElement("select",{className:"gf-form-input",onChange:this.onStateFilterChanged,value:this.getStateFilter()},this.stateFilters.map(this.alertStateFilterOption)))),l.a.createElement("div",{className:"page-action-bar__spacer"}),l.a.createElement("a",{className:"btn btn-secondary",onClick:this.onOpenHowTo},"How to add an alert")),l.a.createElement("section",null,l.a.createElement("ol",{className:"alert-rule-list"},n.map(function(t){return l.a.createElement(c.a,{rule:t,key:t.id,search:r,onTogglePause:function(){return e.onTogglePause(t)}})})))))},t}(r.PureComponent),v={updateLocation:m.c,getAlertRulesAsync:d.b,setSearchQuery:d.c,togglePauseAlertRule:d.d};t.default=Object(s.hot)(e)(Object(i.b)(function(e){return{navModel:Object(p.a)(e.navIndex,"alert-list"),alertRules:Object(h.a)(e.alertRules),stateFilter:e.location.query.state,search:Object(h.b)(e.alertRules),isLoading:e.alertRules.isLoading}},v)(g))}.call(this,a("3UD+")(e))},YAXX:function(e,t,a){"use strict";var n=a("mrSG"),r=a("q1tI"),l=a.n(r),s=a("WG1l"),i=a.n(s),o=a("TSYQ"),c=a.n(o),u=function(e){function t(){return null!==e&&e.apply(this,arguments)||this}return n.c(t,e),t.prototype.renderText=function(e){return l.a.createElement(i.a,{highlightClassName:"highlight-search-match",textToHighlight:e,searchWords:[this.props.search]})},t.prototype.render=function(){var e=this.props,t=e.rule,a=e.onTogglePause,n=c()({fa:!0,"fa-play":"paused"===t.state,"fa-pause":"paused"!==t.state}),r=t.url+"?panelId="+t.panelId+"&fullscreen&edit&tab=alert";return l.a.createElement("li",{className:"alert-rule-item"},l.a.createElement("span",{className:"alert-rule-item__icon "+t.stateClass},l.a.createElement("i",{className:t.stateIcon})),l.a.createElement("div",{className:"alert-rule-item__body"},l.a.createElement("div",{className:"alert-rule-item__header"},l.a.createElement("div",{className:"alert-rule-item__name"},l.a.createElement("a",{href:r},this.renderText(t.name))),l.a.createElement("div",{className:"alert-rule-item__text"},l.a.createElement("span",{className:""+t.stateClass},this.renderText(t.stateText)),l.a.createElement("span",{className:"alert-rule-item__time"}," for ",t.stateAge))),t.info&&l.a.createElement("div",{className:"small muted alert-rule-item__info"},this.renderText(t.info))),l.a.createElement("div",{className:"alert-rule-item__actions"},l.a.createElement("button",{className:"btn btn-small btn-inverse alert-list__btn width-2",title:"Pausing an alert rule prevents it from executing",onClick:a},l.a.createElement("i",{className:n})),l.a.createElement("a",{className:"btn btn-small btn-inverse alert-list__btn width-2",href:r,title:"Edit alert rule"},l.a.createElement("i",{className:"gicon gicon-cog"}))))},t}(r.PureComponent);t.a=u},lPMX:function(e,t,a){"use strict";a.d(t,"b",function(){return n}),a.d(t,"a",function(){return r});var n=function(e){return e.searchQuery},r=function(e){var t=new RegExp(e.searchQuery,"i");return e.items.filter(function(e){return t.test(e.name)||t.test(e.stateText)||t.test(e.info)})}}}]);
//# sourceMappingURL=AlertRuleList.189a5a829d25dac84fc0.js.map
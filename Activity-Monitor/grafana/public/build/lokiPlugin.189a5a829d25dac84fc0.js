(window.webpackJsonp=window.webpackJsonp||[]).push([[34],{"+2Nz":function(e,t,r){"use strict";r.r(t);var n=r("mrSG"),a=r("LvDl"),s=r.n(a),o=r("Obii"),i=r("eqT+"),u=r("ceQ3"),c={comment:{pattern:/(^|[^\n])#.*/,lookbehind:!0},"context-labels":{pattern:/(^|\s)\{[^}]*(?=})/,lookbehind:!0,inside:{"label-key":{pattern:/[a-z_]\w*(?=\s*(=|!=|=~|!~))/,alias:"attr-name"},"label-value":{pattern:/"(?:\\.|[^\\"])*"/,greedy:!0,alias:"attr-value"},punctuation:/[{]/}},operator:new RegExp("/&&?|\\|?\\||!=?|<(?:=>?|<|>)?|>[>=]?","i"),punctuation:/[{}`,.]/},l=r("sBLX"),p=["job","namespace"],f=864e5,d=function(e){return{label:e}},h=function(e){return{start:1e6*e.from,end:1e6*e.to}};var m=function(e){function t(t,r){var n=e.call(this)||this;return n.cleanText=function(e){return e.replace(/[{}[\]="(),!~+\-*\/^%]/g,"").trim()},n.request=function(e,t){return n.datasource.metadataRequest(e,t)},n.start=function(){return n.startTask||(n.startTask=n.fetchLogLabels(n.initialRange).then(function(){return n.started=!0,[]})),n.startTask},n.datasource=t,n.labelKeys={},n.labelValues={},Object.assign(n,r),n}return n.c(t,e),t.prototype.getSyntax=function(){return c},t.prototype.getLabelKeys=function(){return this.labelKeys["{}"]},t.prototype.getLabelValues=function(e){return n.b(this,void 0,Promise,function(){return n.d(this,function(t){switch(t.label){case 0:return[4,this.fetchLabelValues(e,this.initialRange)];case 1:return t.sent(),[2,this.labelValues["{}"][e]]}})})},t.prototype.provideCompletionItems=function(e,t){return n.b(this,void 0,Promise,function(){var r,a,o;return n.d(this,function(n){switch(n.label){case 0:return r=e.wrapperClasses,a=e.value,o=0===a.document.text.length,s.a.includes(r,"context-labels")?[4,this.getLabelCompletionItems(e,t)]:[3,2];case 1:return[2,n.sent()];case 2:if(o)return[2,this.getEmptyCompletionItems(t||{})];n.label=3;case 3:return[2,{suggestions:[]}]}})})},t.prototype.getEmptyCompletionItems=function(e){var t=e.history,r=[];if(t&&t.length>0){var a=s.a.chain(t).map(function(e){return e.query.expr}).filter().uniq().take(10).map(d).map(function(e){return function(e,t){var r=Date.now()-f,a=t.filter(function(t){return t.ts>r&&t.query.expr===e.label}),s=a.length,i=a[0],u="Queried "+s+" times in the last 24h.";return i&&(u=u+" Last queried "+Object(o.dateTime)(i.ts).fromNow()+"."),n.a({},e,{documentation:u})}(e,t)}).value();r.push({prefixMatch:!0,skipSort:!0,label:"History",items:a})}return{suggestions:r}},t.prototype.getLabelCompletionItems=function(e,t){var r=e.text,a=e.wrapperClasses,o=e.labelKey,i=e.value,c=t.absoluteRange;return n.b(this,void 0,Promise,function(){var e,t,l,f,h,m,b,v,y,g;return n.d(this,function(n){switch(n.label){case 0:t=[],l=i.anchorBlock.getText(),f=i.selection.anchor.offset,h="{}";try{m=Object(u.c)(l,f)}catch(e){}return b=m?m.labelKeys:[],r&&r.match(/^!?=~?/)||a.includes("attr-value")?o&&this.labelValues[h]?(v=this.labelValues[h][o])?[3,2]:[4,this.fetchLabelValues(o,c)]:[3,3]:[3,4];case 1:n.sent(),v=this.labelValues[h][o],n.label=2;case 2:e="context-label-values",t.push({label:'Label values for "'+o+'"',items:v.map(d)}),n.label=3;case 3:return[3,5];case 4:(y=this.labelKeys[h]||p)&&(g=s.a.difference(y,b)).length>0&&(e="context-labels",t.push({label:"Labels",items:g.map(d)})),n.label=5;case 5:return[2,{context:e,suggestions:t}]}})})},t.prototype.importQueries=function(e,t){return n.b(this,void 0,Promise,function(){var r=this;return n.d(this,function(a){return"prometheus"===t?[2,Promise.all(e.map(function(e){return n.b(r,void 0,void 0,function(){var t,r,a;return n.d(this,function(s){switch(s.label){case 0:return[4,this.importPrometheusQuery(e.expr)];case 1:return t=s.sent(),(r=e).context,a=n.g(r,["context"]),[2,n.a({},a,{expr:t})]}})})}))]:[2,e.map(function(e){return{refId:e.refId,expr:""}})]})})},t.prototype.importPrometheusQuery=function(e){return n.b(this,void 0,Promise,function(){var t,r,a,s,o,i,c;return n.d(this,function(n){switch(n.label){case 0:return e?(t=e.match(u.f))?(r=t[0],a={},r.replace(u.b,function(e,t,r,n){return a[t]={value:n,operator:r},""}),[4,this.start()]):[3,2]:[2,""];case 1:if(n.sent(),s=this.labelKeys["{}"],o={},s&&s.length>0)for(i in a)s&&s.includes(i)&&(o[i]=a[i]);else o=a;return c=Object.keys(o).sort(),[2,["{",c.map(function(e){return""+e+o[e].operator+o[e].value}).join(","),"}"].join("")];case 2:return[2,""]}})})},t.prototype.fetchLogLabels=function(e){return n.b(this,void 0,Promise,function(){var t,r,a,s,o,i,u;return n.d(this,function(c){switch(c.label){case 0:t="/api/prom/label",c.label=1;case 1:return c.trys.push([1,4,,5]),this.logLabelFetchTs=Date.now(),[4,this.request(t,h(e))];case 2:return[4,(r=c.sent()).data||r.json()];case 3:return a=c.sent(),s=a.data.slice().sort(),this.labelKeys=n.a({},this.labelKeys,((i={})["{}"]=s,i)),this.labelValues=((u={})["{}"]={},u),this.logLabelOptions=s.map(function(e){return{label:e,value:e,isLeaf:!1}}),[3,5];case 4:return o=c.sent(),console.error(o),[3,5];case 5:return[2,[]]}})})},t.prototype.refreshLogLabels=function(e,t){return n.b(this,void 0,void 0,function(){return n.d(this,function(r){switch(r.label){case 0:return this.labelKeys&&Date.now()-this.logLabelFetchTs>3e4||t?[4,this.fetchLogLabels(e)]:[3,2];case 1:r.sent(),r.label=2;case 2:return[2]}})})},t.prototype.fetchLabelValues=function(e,t){return n.b(this,void 0,void 0,function(){var r,a,s,o,i,u,c,l,p;return n.d(this,function(f){switch(f.label){case 0:r="/api/prom/label/"+e+"/values",f.label=1;case 1:return f.trys.push([1,4,,5]),[4,this.request(r,h(t))];case 2:return[4,(a=f.sent()).data||a.json()];case 3:return s=f.sent(),o=s.data.slice().sort(),this.logLabelOptions=this.logLabelOptions.map(function(t){return t.value===e?n.a({},t,{children:o.map(function(e){return{label:e,value:e}})}):t}),i=this.labelValues["{}"],u=n.a({},i,((l={})[e]=o,l)),this.labelValues=n.a({},this.labelValues,((p={})["{}"]=u,p)),[3,5];case 4:return c=f.sent(),console.error(c),[3,5];case 5:return[2]}})})},t}(l.d);function b(e,t,r){var a,s,i=e.parsedLabels;!i&&e.labels&&(i=Object(o.parseLabels)(e.labels));var u=new o.ArrayVector([]),c=new o.ArrayVector([]);try{for(var l=n.i(e.entries),p=l.next();!p.done;p=l.next()){var f=p.value;u.add(f.ts||f.timestamp),c.add(f.line)}}catch(e){a={error:e}}finally{try{p&&!p.done&&(s=l.return)&&s.call(l)}finally{if(a)throw a.error}}return t&&(u.buffer=u.buffer.reverse(),c.buffer=c.buffer.reverse()),{refId:r,labels:i,fields:[{name:"ts",type:o.FieldType.time,config:{title:"Time"},values:u},{name:"line",type:o.FieldType.string,config:{},values:c}],length:u.length}}var v=/(?:^|\s){[^{]*}/g,y="(?i)";function g(e){var t=(e=e||"").match(v),r=e,n="";return t&&((n=e.replace(v,"").trim())&&-1===n.search(/\|=|\|~|!=|!~/)?(r=t[0].trim(),n.startsWith(y)||(n=""+y+n)):n=""),{regexp:n,query:r}}function _(e,t){return((e||"")+" "+(t||"")).trim()}function x(e){var t=g(e);if(t.regexp)return[t.regexp];for(var r=e,n=[];r;){var a=r.search(/\|=|\|~|!=|!~/);if(-1===a)break;var s=0===r.substr(a).search(/!=|!~/);if(r=r.substr(a+2),!s){var o=r.search(/\|=|\|~|!=|!~/),i=void 0;-1===o?i=r.trim():(i=r.substr(0,o).trim(),r=r.substr(o));var u=i.match(/^"((?:[^\\"]|\\")*)"$/);if(!u)return null;var c=u[1];n.push(c)}}return n}var w=r("kDLi"),L=r("m257"),k=r("K9Ia"),S=r("FFOo"),O=r("6blF"),E=r("pugT"),j=r("S5bw"),q={url:"",deserializer:function(e){return JSON.parse(e.data)},serializer:function(e){return JSON.stringify(e)}},C=function(e){function t(t,r){var a=e.call(this)||this;if(t instanceof O.a)a.destination=r,a.source=t;else{var s=a._config=n.a({},q);if(a._output=new k.b,"string"==typeof t)s.url=t;else for(var o in t)t.hasOwnProperty(o)&&(s[o]=t[o]);if(!s.WebSocketCtor&&WebSocket)s.WebSocketCtor=WebSocket;else if(!s.WebSocketCtor)throw new Error("no WebSocket constructor can be found");a.destination=new j.a}return a}return n.c(t,e),t.prototype.lift=function(e){var r=new t(this._config,this.destination);return r.operator=e,r.source=this,r},t.prototype._resetState=function(){this._socket=null,this.source||(this.destination=new j.a),this._output=new k.b},t.prototype.multiplex=function(e,t,r){var n=this;return new O.a(function(a){try{n.next(e())}catch(e){a.error(e)}var s=n.subscribe(function(e){try{r(e)&&a.next(e)}catch(e){a.error(e)}},function(e){return a.error(e)},function(){return a.complete()});return function(){try{n.next(t())}catch(e){a.error(e)}s.unsubscribe()}})},t.prototype._connectSocket=function(){var e=this,t=this._config,r=t.WebSocketCtor,n=t.protocol,a=t.url,s=t.binaryType,o=this._output,i=null;try{i=n?new r(a,n):new r(a),this._socket=i,s&&(this._socket.binaryType=s)}catch(e){return void o.error(e)}var u=new E.a(function(){e._socket=null,i&&1===i.readyState&&i.close()});i.onopen=function(t){if(!e._socket)return i.close(),void e._resetState();var r=e._config.openObserver;r&&r.next(t);var n=e.destination;e.destination=S.a.create(function(t){if(1===i.readyState)try{var r=e._config.serializer;i.send(r(t))}catch(t){e.destination.error(t)}},function(t){var r=e._config.closingObserver;r&&r.next(void 0),t&&t.code?i.close(t.code,t.reason):o.error(new TypeError("WebSocketSubject.error must be called with an object with an error code, and an optional reason: { code: number, reason: string }")),e._resetState()},function(){var t=e._config.closingObserver;t&&t.next(void 0),i.close(),e._resetState()}),n&&n instanceof j.a&&u.add(n.subscribe(e.destination))},i.onerror=function(t){e._resetState(),o.error(t)},i.onclose=function(t){e._resetState();var r=e._config.closeObserver;r&&r.next(t),t.wasClean?o.complete():o.error(t)},i.onmessage=function(t){try{var r=e._config.deserializer;o.next(r(t))}catch(e){o.error(e)}}},t.prototype._subscribe=function(e){var t=this,r=this.source;return r?r.subscribe(e):(this._socket||this._connectSocket(),this._output.subscribe(e),e.add(function(){var e=t._socket;0===t._output.observers.length&&(e&&1===e.readyState&&e.close(),t._resetState())}),e)},t.prototype.unsubscribe=function(){var t=this._socket;t&&1===t.readyState&&t.close(),this._resetState(),e.prototype.unsubscribe.call(this)},t}(k.a);var T=r("2WpN"),D=r("67Y/"),R=function(){function e(){this.streams={}}return e.prototype.getStream=function(e){var t,r=this,a=this.streams[e.url];if(!a){var s=new o.CircularDataFrame({capacity:e.size});s.labels=Object(o.parseLabels)(e.query),s.addField({name:"ts",type:o.FieldType.time,config:{title:"Time"}}),s.addField({name:"line",type:o.FieldType.string}),s.addField({name:"labels",type:o.FieldType.other}),a=(t=e.url,new C(t)).pipe(Object(T.a)(function(){delete r.streams[e.url]}),Object(D.a)(function(e){return function(e,t){var r,a,s,i,u=e.streams;if(u&&u.length)try{for(var c=n.i(u),l=c.next();!l.done;l=c.next()){var p=l.value,f=Object(o.parseLabels)(p.labels),d=Object(o.findUniqueLabels)(f,t.labels);try{for(var h=(s=void 0,n.i(p.entries)),m=h.next();!m.done;m=h.next()){var b=m.value;t.values.ts.add(b.ts||b.timestamp),t.values.line.add(b.line),t.values.labels.add(d)}}catch(e){s={error:e}}finally{try{m&&!m.done&&(i=h.return)&&i.call(h)}finally{if(s)throw s.error}}}}catch(e){r={error:e}}finally{try{l&&!l.done&&(a=c.return)&&a.call(c)}finally{if(r)throw r.error}}}(e,s),[s]})),this.streams[e.url]=a}return a},e}(),I=r("0/uQ"),Q=r("p0ib"),P=r("VnD/"),N=1e3,A={direction:"BACKWARD",limit:N,regexp:"",query:""};function V(e){return Object.keys(e).map(function(t){var r=e[t];return encodeURIComponent(t)+"="+encodeURIComponent(r)}).join("&")}var F=function(e){function t(t,r,a){var s=e.call(this,t)||this;s.instanceSettings=t,s.backendSrv=r,s.templateSrv=a,s.streams=new R,s.processError=function(e,t){var r={message:"Unknown error during query transaction. Please check JS console logs.",refId:t.refId};return e.data?"string"==typeof e.data?r.message=e.data:e.data.error&&(r.message=Object(L.t)(e.data.error)):e.message?r.message=e.message:"string"==typeof e&&(r.message=e),r.status=e.status,r.statusText=e.statusText,r},s.processResult=function(e,t){var r,a,o=[];if(0===Object.keys(e).length)return o;if(!e.streams)return[b(e,!1,t.refId)];e=e;try{for(var i=n.i(e.streams||[]),u=i.next();!u.done;u=i.next()){var c=b(u.value);c.refId=t.refId,c.meta={searchWords:x(_(t.query,t.regexp)),limit:s.maxLines},o.push(c)}}catch(e){r={error:e}}finally{try{u&&!u.done&&(a=i.return)&&a.call(i)}finally{if(r)throw r.error}}return o},s.runLiveQuery=function(e,t){var r=s.prepareLiveTarget(t,e);return s.streams.getStream(r).pipe(Object(D.a)(function(e){return{data:e,key:"loki-"+r.refId,state:o.LoadingState.Streaming}}))},s.runQuery=function(e,t){var r=s.prepareQueryTarget(t,e);return Object(I.a)(s._request("/api/prom/query",r).catch(function(e){if(e.cancelled)return e;throw s.processError(e,r)})).pipe(Object(P.a)(function(e){return!e.cancelled}),Object(D.a)(function(e){return{data:s.processResult(e.data,r),key:r.refId}}))},s.prepareLogRowContextQueryTarget=function(e,t,r){var a=Object.keys(e.labels).map(function(t){return t+'="'+e.labels[t]+'"'}).join(","),s=1e6*e.timeEpochMs,o={limit:t,query:"{"+a+"}",direction:r};return"BACKWARD"===r?n.a({},o,{start:s-72e11,end:e.timestamp,direction:r}):n.a({},o,{start:e.timestamp,end:s+72e11})},s.getLogRowContext=function(e,t){return n.b(s,void 0,void 0,function(){var r,a,s,o,i,u,c,l,p,f;return n.d(this,function(d){switch(d.label){case 0:r=this.prepareLogRowContextQueryTarget(e,t&&t.limit||10,t&&t.direction||"BACKWARD"),a=[],d.label=1;case 1:return d.trys.push([1,3,,4]),s=t&&"FORWARD"===t.direction,[4,this._request("/api/prom/query",r)];case 2:if((o=d.sent()).data)try{for(i=n.i(o.data.streams||[]),u=i.next();!u.done;u=i.next())c=u.value,a.push(b(c,s))}catch(e){p={error:e}}finally{try{u&&!u.done&&(f=i.return)&&f.call(i)}finally{if(p)throw p.error}}return[2,{data:a}];case 3:throw l=d.sent(),{message:"Error during context query. Please check JS console logs.",status:l.status,statusText:l.statusText};case 4:return[2]}})})},s.languageProvider=new m(s);var i=t.jsonData||{};return s.maxLines=parseInt(i.maxLines,10)||N,s}return t.$inject=["instanceSettings","backendSrv","templateSrv"],n.c(t,e),t.prototype._request=function(e,t,r){var a=""+this.instanceSettings.url+e+"?"+(t?V(t):""),s=n.a({},r,{url:a});return this.backendSrv.datasourceRequest(s)},t.prototype.prepareLiveTarget=function(e,t){var r=g(this.templateSrv.replace(e.expr)),n=r.query,a=r.regexp,s=e.refId,o=this.instanceSettings.url,i=V({query:n,regexp:a});return{query:n,regexp:a,url:Object(L.f)(o+"/api/prom/tail?"+i),refId:s,size:Math.min(t.maxDataPoints||1/0,this.maxLines)}},t.prototype.prepareQueryTarget=function(e,t){var r=g(this.templateSrv.replace(e.expr)),a=r.query,s=r.regexp,o=this.getTime(t.range.from,!1),i=this.getTime(t.range.to,!0),u=e.refId;return n.a({},A,{query:a,regexp:s,start:o,end:i,limit:Math.min(t.maxDataPoints||1/0,this.maxLines),refId:u})},t.prototype.query=function(e){var t=this,r=e.targets.filter(function(e){return e.expr&&!e.hide}).map(function(r){return r.liveStreaming?t.runLiveQuery(e,r):t.runQuery(e,r)});return Q.a.apply(void 0,n.h(r))},t.prototype.importQueries=function(e,t){return n.b(this,void 0,Promise,function(){return n.d(this,function(r){return[2,this.languageProvider.importQueries(e,t.id)]})})},t.prototype.metadataRequest=function(e,t){var r=e.replace("v1","prom");return this._request(r,t,{silent:!0}).then(function(e){return{data:{data:e.data.values||[]}}})},t.prototype.modifyQuery=function(e,t){var r=g(e.expr||""),a=r.query;switch(t.type){case"ADD_FILTER":a=Object(i.a)(a,t.key,t.value)}var s=_(a,r.regexp);return n.a({},e,{expr:s})},t.prototype.getHighlighterExpression=function(e){return x(e.expr)},t.prototype.getTime=function(e,t){return s.a.isString(e)&&(e=o.dateMath.parse(e,t)),Math.ceil(1e6*e.valueOf())},t.prototype.testDatasource=function(){var e=Date.now()-6e5+"000000";return this._request("/api/prom/label",{start:e}).then(function(e){return e&&e.data&&e.data.values&&e.data.values.length>0?{status:"success",message:"Data source connected and labels found."}:{status:"error",message:"Data source connected, but no labels received. Verify that Loki and Promtail is configured properly."}}).catch(function(e){var t="Loki: ";return e.statusText?t+=e.statusText:t+="Cannot connect to Loki",e.status&&(t+=". "+e.status),e.data&&e.data.message?t+=". "+e.data.message:e.data&&(t+=". "+e.data),{status:"error",message:t}})},t.prototype.annotationQuery=function(e){return n.b(this,void 0,Promise,function(){var t,r,a,s,i,u,c,l,p;return n.d(this,function(f){switch(f.label){case 0:return e.annotation.expr?(t=function(e){var t="annotation-"+e.annotation.name,r={refId:t,expr:e.annotation.expr};return{requestId:t,range:e.range,targets:[r],dashboardId:e.dashboard.id,scopedVars:null,startTime:Date.now(),maxDataPoints:0,timezone:"utc",panelId:0,interval:"",intervalMs:0}}(e),[4,this.runQuery(t,t.targets[0]).toPromise()]):[2,[]];case 1:r=f.sent().data,a=[],s=function(e){var t=Object.values(e.labels);new o.DataFrameView(e).forEachRow(function(e){a.push({time:new Date(e.ts).valueOf(),text:e.line,tags:t})})};try{for(i=n.i(r),u=i.next();!u.done;u=i.next())c=u.value,s(c)}catch(e){l={error:e}}finally{try{u&&!u.done&&(p=i.return)&&p.call(i)}finally{if(l)throw l.error}}return[2,a]}})})},t}(w.DataSourceApi),K=r("q1tI"),W=r.n(K),z=['{job="default/prometheus"}'],U=["job","app","k8s_app"],M=5,B=function(e){function t(){var t=null!==e&&e.apply(this,arguments)||this;return t.state={userExamples:z},t.checkUserLabels=function(){return n.b(t,void 0,void 0,function(){var e,t,r,s,o;return n.d(this,function(n){switch(n.label){case 0:return(e=this.props.datasource.languageProvider).started?(t=e.getLabelKeys()||[],(r=U.find(function(e){return t.includes(e)}))?[4,e.getLabelValues(r)]:[3,2]):[3,3];case 1:s=n.sent(),o=Object(a.shuffle)(s).slice(0,M).map(function(e){return"{"+r+'="'+e+'"}'}),this.setState({userExamples:o}),n.label=2;case 2:return[3,4];case 3:this.scheduleUserLabelChecking(),n.label=4;case 4:return[2]}})})},t}return n.c(t,e),t.prototype.componentDidMount=function(){this.scheduleUserLabelChecking()},t.prototype.componentWillUnmount=function(){clearTimeout(this.userLabelTimer)},t.prototype.scheduleUserLabelChecking=function(){this.userLabelTimer=setTimeout(this.checkUserLabels,1e3)},t.prototype.renderExpression=function(e){var t=this.props.onClickExample;return W.a.createElement("div",{className:"cheat-sheet-item__example",key:e,onClick:function(r){return t({refId:"A",expr:e})}},W.a.createElement("code",null,e))},t.prototype.render=function(){var e=this,t=this.state.userExamples;return W.a.createElement("div",null,W.a.createElement("h2",null,"Loki Cheat Sheet"),W.a.createElement("div",{className:"cheat-sheet-item"},W.a.createElement("div",{className:"cheat-sheet-item__title"},"See your logs"),W.a.createElement("div",{className:"cheat-sheet-item__label"},"Start by selecting a log stream from the Log labels selector."),W.a.createElement("div",{className:"cheat-sheet-item__label"},"Alternatively, you can write a stream selector into the query field:"),this.renderExpression('{job="default/prometheus"}'),t!==z&&t.length>0?W.a.createElement("div",null,W.a.createElement("div",{className:"cheat-sheet-item__label"},"Here are some example streams from your logs:"),t.map(function(t){return e.renderExpression(t)})):null),W.a.createElement("div",{className:"cheat-sheet-item"},W.a.createElement("div",{className:"cheat-sheet-item__title"},"Combine stream selectors"),this.renderExpression('{app="cassandra",namespace="prod"}'),W.a.createElement("div",{className:"cheat-sheet-item__label"},"Returns all log lines from streams that have both labels.")),W.a.createElement("div",{className:"cheat-sheet-item"},W.a.createElement("div",{className:"cheat-sheet-item__title"},"Filtering for search terms."),this.renderExpression('{app="cassandra"} |~ "(duration|latency)s*(=|is|of)s*[d.]+"'),this.renderExpression('{app="cassandra"} |= "exact match"'),this.renderExpression('{app="cassandra"} != "do not match"'),W.a.createElement("div",{className:"cheat-sheet-item__label"},W.a.createElement("a",{href:"https://github.com/grafana/loki/blob/master/docs/logql.md#filter-expression",target:"logql"},"LogQL")," ","supports exact and regular expression filters.")))},t}(K.PureComponent),J=r("KwPh"),$=r("uz0r"),H=function(e){var t=e.datasource,r=e.datasourceStatus,a=n.g(e,["datasource","datasourceStatus"]),s=Object($.a)(t.languageProvider,r,a.absoluteRange),o=s.isSyntaxReady,i=s.setActiveOption,u=s.refreshLabels,c=n.g(s,["isSyntaxReady","setActiveOption","refreshLabels"]);return W.a.createElement(J.a,n.a({datasource:t,datasourceStatus:r,syntaxLoaded:o,onLoadOptions:i,onLabelsRefresh:u},c,a))},Z=H,G=Object(K.memo)(function(e){var t,r=e.query,a=e.panelData,s=e.datasource,o=e.onChange,i=e.onRunQuery;if(a&&a.request){var u=a.request.range;t={from:u.from.valueOf(),to:u.to.valueOf()}}else t={from:Date.now()-1e4,to:Date.now()};var c=Object($.a)(s.languageProvider,w.DataSourceStatus.Connected,t),l=c.isSyntaxReady,p=c.setActiveOption,f=c.refreshLabels,d=n.g(c,["isSyntaxReady","setActiveOption","refreshLabels"]);return W.a.createElement("div",null,W.a.createElement(H,n.a({datasource:s,datasourceStatus:w.DataSourceStatus.Connected,query:r,onChange:o,onRunQuery:i,history:[],panelData:a,onLoadOptions:p,onLabelsRefresh:f,syntaxLoaded:l,absoluteRange:t},d)))}),X=function(){function e(){this.annotation.target=this.annotation.target||{},this.onQueryChange=this.onQueryChange.bind(this)}return e.prototype.onQueryChange=function(e){this.annotation.expr=e},e.templateUrl="partials/annotations.editor.html",e}();r.d(t,"LokiConfigCtrl",function(){return Y}),r.d(t,"ConfigCtrl",function(){return Y}),r.d(t,"Datasource",function(){return F}),r.d(t,"QueryEditor",function(){return G}),r.d(t,"ExploreQueryField",function(){return Z}),r.d(t,"ExploreStartPage",function(){return B}),r.d(t,"AnnotationsQueryCtrl",function(){return X});var Y=function(){function e(){}return e.templateUrl="partials/config.html",e}()},ceQ3:function(e,t,r){"use strict";r.d(t,"d",function(){return a}),r.d(t,"e",function(){return s}),r.d(t,"f",function(){return o}),r.d(t,"b",function(){return i}),r.d(t,"c",function(){return u}),r.d(t,"a",function(){return c});var n=r("mrSG"),a=function(e){for(var t=[],r=new RegExp("_bucket($|:)"),n=0;n<e.length;n++){var a=e[n];r.test(a)&&-1===t.indexOf(a)&&t.push(a)}return{values:{__name__:t}}};function s(e,t){void 0===t&&(t=!1);var r={};return e.forEach(function(e){var a=e.__name__,s=n.g(e,["__name__"]);t&&(r.__name__=r.__name__||[],r.__name__.includes(a)||r.__name__.push(a)),Object.keys(s).forEach(function(e){r[e]||(r[e]=[]),r[e].includes(s[e])||r[e].push(s[e])})}),{values:r,keys:Object.keys(r)}}var o=/\{[^}]*?\}/,i=/\b(\w+)(!?=~?)("[^"\n]*?")/g;function u(e,t){if(void 0===t&&(t=1),!e.match(o)){if(e.match(/^[A-Za-z:][\w:]*$/))return{selector:'{__name__="'+e+'"}',labelKeys:["__name__"]};throw new Error("Query must contain a selector: "+e)}var r=e.slice(0,t),n=r.lastIndexOf("{"),a=r.lastIndexOf("}");if(-1===n)throw new Error("Not inside selector, missing open brace: "+r);if(a>-1&&a>n)throw new Error("Not inside selector, previous selector already closed: "+r);var s=e.slice(t),u=s.indexOf("}")+t,c=s.indexOf("{"),l=c+t;if(-1===u)throw new Error("Not inside selector, missing closing brace in suffix: "+s);if(c>-1&&l<u)throw new Error("Not inside selector, next selector opens before this one closed: "+s);var p=e.slice(n,u),f={};p.replace(i,function(e,t,r,n){return f[t]={value:n,operator:r},""});var d=e.slice(0,n).match(/[A-Za-z:][\w:]*$/);d&&(f.__name__={value:'"'+d[0]+'"',operator:"="});var h=Object.keys(f).sort(),m=h.map(function(e){return""+e+f[e].operator+f[e].value}).join(",");return{labelKeys:h,selector:["{",m,"}"].join("")}}function c(e,t){var r=Object.keys(t),n=new RegExp("(\\s|^)("+r.join("|")+")(\\s|$|\\(|\\[|\\{)","ig");return e.replace(n,function(e,r,n,a){return""+r+t[n]+a})}},"eqT+":function(e,t,r){"use strict";r.d(t,"a",function(){return l});var n=r("LvDl"),a=r.n(n),s="by|without|on|ignoring|group_left|group_right|bool|or|and|unless",o=[s,"count|count_values|min|max|avg|sum|stddev|stdvar|bottomk|topk|quantile","true|false|null|__name__|job","abs|absent|ceil|changes|clamp_max|clamp_min|count_scalar|day_of_month|day_of_week|days_in_month|delta|deriv","drop_common_labels|exp|floor|histogram_quantile|holt_winters|hour|idelta|increase|irate|label_replace|ln|log2","log10|minute|month|predict_linear|rate|resets|round|scalar|sort|sort_desc|sqrt|time|vector|year|avg_over_time","min_over_time|max_over_time|sum_over_time|count_over_time|quantile_over_time|stddev_over_time|stdvar_over_time"].join("|").split("|"),i=/([A-Za-z:][\w:]*)\b(?![\(\]{=!",])/g,u=/{([^{]*)}/g;var c=/(\w+)\s*(=|!=|=~|!~)\s*("[^"]*")/g;function l(e,t,r,n){var s=[];if(e)for(var o=c.exec(e);o;)s.push({key:o[1],operator:o[2],value:o[3]}),o=c.exec(e);var i=n||"=";return s.push({key:t,operator:i,value:'"'+r+'"'}),"{"+a.a.chain(s).uniqWith(a.a.isEqual).compact().sortBy("key").map(function(e){return""+e.key+e.operator+e.value}).value().join(",")+"}"}t.b=function(e,t,r,n){if(!t||!r)throw new Error("Need label to add to query.");var a;e=e.replace(i,function(t,r,n){var i,u,c,l,p,f,d=(u=n,c="{",l="}",p=(i=e).slice(u).indexOf(c),(f=i.slice(u).indexOf(l))>-1&&(-1===p||p>f)),h=a&&s.split("|").indexOf(a)>-1,m=r.endsWith(":");return a=r,d||m||h||-1!==o.indexOf(r)?r:r+"{}"});for(var c=u.exec(e),p=[],f=0,d="";c;){var h=e.slice(f,c.index),m=l(c[1],t,r,n);f=c.index+c[1].length+2,d=e.slice(c.index+c[0].length),p.push(h,m),c=u.exec(e)}return p.push(d),p.join("")}}}]);
//# sourceMappingURL=lokiPlugin.189a5a829d25dac84fc0.js.map